using System;
using System.Collections.Generic;
using System.Text;
using FdoToolbox.Core.Feature;
using FdoToolbox.Core;
using ICSharpCode.Core;

//TODO: Move exception messages to Errors.resx

namespace FdoToolbox.Base.Services
{
    public sealed class FdoConnectionManager : IFdoConnectionManager
    {
        private Dictionary<string, FdoConnection> _ConnectionDict = new Dictionary<string, FdoConnection>();

        private int counter = 0;

        public void Clear()
        {
            List<string> names = new List<string>(GetConnectionNames());
            foreach (string name in names)
            {
                this.RemoveConnection(name);
            }
        }

        public bool NameExists(string name)
        {
            if (name == null)
                return false;
            return _ConnectionDict.ContainsKey(name);
        }

        public string CreateUniqueName()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void AddConnection(string name, FdoToolbox.Core.Feature.FdoConnection conn)
        {
            if (_ConnectionDict.ContainsKey(name))
                throw new FdoConnectionException("Unable to add connection named " + name + " to the connection manager");
            conn.Open();
            _ConnectionDict.Add(name, conn);
            this.ConnectionAdded(this, new EventArgs<string>(name));
        }

        public void RemoveConnection(string name)
        {
            if (_ConnectionDict.ContainsKey(name))
            {
                ConnectionBeforeRenameEventArgs e = new ConnectionBeforeRenameEventArgs(name);
                this.BeforeConnectionRemove(this, e);
                if (e.Cancel)
                    return;

                FdoConnection conn = _ConnectionDict[name];
                conn.Close();
                _ConnectionDict.Remove(name);
                conn.Dispose();
                if (this.ConnectionRemoved != null)
                    this.ConnectionRemoved(this, new EventArgs<string>(name));

                //Reset counter if no connections left
                if (_ConnectionDict.Count == 0)
                    counter = 0;
            }
        }

        public FdoToolbox.Core.Feature.FdoConnection GetConnection(string name)
        {
            if (_ConnectionDict.ContainsKey(name))
                return _ConnectionDict[name];
            return null;
        }

        public ICollection<string> GetConnectionNames()
        {
            return _ConnectionDict.Keys;
        }

        public void RenameConnection(string oldName, string newName)
        {
            if (!_ConnectionDict.ContainsKey(oldName))
                throw new FdoConnectionException("The connection to be renamed could not be found: " + oldName);
            if (_ConnectionDict.ContainsKey(newName))
                throw new FdoConnectionException("Cannot rename connection " + oldName + " to " + newName + " as a connection of that name already exists");

            FdoConnection conn = _ConnectionDict[oldName];
            _ConnectionDict.Remove(oldName);
            _ConnectionDict.Add(newName, conn);

            ConnectionRenameEventArgs e = new ConnectionRenameEventArgs(oldName, newName);
            this.ConnectionRenamed(this, e);
        }

        public ConnectionRenameResult CanRenameConnection(string oldName, string newName)
        {
            string reason = string.Empty;
            bool result = false;
            if (!_ConnectionDict.ContainsKey(oldName))
            {
                reason = "The connection to be renamed could not be found: " + oldName;
                result = false;
                return new ConnectionRenameResult(result, reason);
            }
            if (_ConnectionDict.ContainsKey(newName))
            {
                reason = "Cannot rename connection " + oldName + " to " + newName + " as a connection of that name already exists";
                result = false;
                return new ConnectionRenameResult(result, reason);
            }
            return new ConnectionRenameResult();
        }

        public event ConnectionBeforeRemoveHandler BeforeConnectionRemove = delegate { };

        public event ConnectionEventHandler ConnectionAdded = delegate { };

        public event ConnectionEventHandler ConnectionRemoved = delegate { };

        public event ConnectionRenamedEventHandler ConnectionRenamed = delegate { };

        public event ConnectionEventHandler ConnectionRefreshed = delegate { };

        private bool _init = false;

        public bool IsInitialized
        {
            get { return _init; }
        }

        public void InitializeService()
        {
            LoggingService.Info("Initialized Connection Manager Service");
            _init = true;
            Initialize(this, EventArgs.Empty);
        }

        public void UnloadService()
        {
            Unload(this, EventArgs.Empty);
        }

        public event EventHandler Initialize = delegate { };

        public event EventHandler Unload = delegate { };

        public void RefreshConnection(string name)
        {
            if (NameExists(name))
            {
                //TODO: Actually destroy and rebuild the connection?
                ConnectionRefreshed(this, new EventArgs<string>(name));
            }
        }
    }
}
