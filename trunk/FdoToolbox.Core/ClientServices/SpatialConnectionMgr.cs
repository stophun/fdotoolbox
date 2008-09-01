#region LGPL Header
// Copyright (C) 2008, Jackie Ng
// http://code.google.com/p/fdotoolbox, jumpinjackie@gmail.com
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using OSGeo.FDO.Connections;
using FdoToolbox.Core.Controls;
using FdoToolbox.Core.Common;

namespace FdoToolbox.Core.ClientServices
{
    /// <summary>
    /// FDO Connection Manager
    /// </summary>
    public class SpatialConnectionMgr : ISpatialConnectionMgr
    {
        private int counter;

        private Dictionary<string, FdoConnectionInfo> _ConnectionDict;

        public SpatialConnectionMgr() 
        {
            _ConnectionDict = new Dictionary<string, FdoConnectionInfo>();
            _FeatureServices = new Dictionary<string, FeatureService>();
        }

        public void AddConnection(string name, OSGeo.FDO.Connections.IConnection conn)
        {
            if (_ConnectionDict.ContainsKey(name))
                throw new FdoConnectionException("Unable to add connection named " + name + " to the connection manager");
            if (conn.ConnectionState != ConnectionState.ConnectionState_Open)
                conn.Open();
            FdoConnectionInfo connInfo = new FdoConnectionInfo(name, conn);
            _ConnectionDict.Add(name, connInfo);
            if (this.ConnectionAdded != null)
                this.ConnectionAdded(name);
        }

        public void RemoveConnection(string name)
        {
            if (_ConnectionDict.ContainsKey(name))
            {
                if (this.BeforeConnectionRemove != null)
                {
                    bool cancel = false;
                    this.BeforeConnectionRemove(name, ref cancel);
                    if (cancel)
                        return;
                }

                FdoConnectionInfo conn = _ConnectionDict[name];
                conn.Close();
                
                _ConnectionDict.Remove(name);

                if (_FeatureServices.ContainsKey(name))
                {
                    FeatureService service = _FeatureServices[name];
                    _FeatureServices.Remove(name);
                    service.Dispose();
                }

                conn.Dispose();
                if (this.ConnectionRemoved != null)
                    this.ConnectionRemoved(name);

                //Reset counter if no connections left
                if (_ConnectionDict.Count == 0)
                    counter = 0;
            }
        }

        public FdoConnectionInfo GetConnection(string name)
        {
            if (_ConnectionDict.ContainsKey(name))
                return _ConnectionDict[name];
            return null;
        }
        
        public ICollection<string> GetConnectionNames()
        {
            return _ConnectionDict.Keys;
        }

        public string CreateUniqueName()
        {
            return "Connection" + (counter++);
        }
        
        public event ConnectionEventHandler ConnectionAdded;

        public event ConnectionEventHandler ConnectionRemoved;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (string name in GetConnectionNames())
                {
                    _ConnectionDict[name].Close();
                    _ConnectionDict[name].Dispose();
                }
                _ConnectionDict.Clear();
            }
        }

        public void RenameConnection(string oldName, string newName)
        {
            if (!_ConnectionDict.ContainsKey(oldName))
                throw new FdoConnectionException("The connection to be renamed could not be found: " + oldName);
            if (_ConnectionDict.ContainsKey(newName))
                throw new FdoConnectionException("Cannot rename connection " + oldName + " to " + newName + " as a connection of that name already exists");

            FdoConnectionInfo conn = _ConnectionDict[oldName];
            _ConnectionDict.Remove(oldName);
            _ConnectionDict.Add(newName, conn);

            if (_FeatureServices.ContainsKey(oldName))
            {
                FeatureService service = _FeatureServices[oldName];
                _FeatureServices.Remove(oldName);
                _FeatureServices[newName] = service;
            }

            if (this.ConnectionRenamed != null)
                this.ConnectionRenamed(oldName, newName);
        }

        public event ConnectionRenamedEventHandler ConnectionRenamed;

        public bool CanRenameConnection(string oldName, string newName, ref string reason)
        {
            if (!_ConnectionDict.ContainsKey(oldName))
            {
                reason = "The connection to be renamed could not be found: " + oldName;
                return false;
            }
            if (_ConnectionDict.ContainsKey(newName))
            {
                reason = "Cannot rename connection " + oldName + " to " + newName + " as a connection of that name already exists";
                return false;
            }
            return true;
        }


        public event ConnectionBeforeRemoveHandler BeforeConnectionRemove;

        private Dictionary<string, FeatureService> _FeatureServices;

        public FeatureService CreateService(string name)
        {
            if (!_ConnectionDict.ContainsKey(name))
                return null;

            return _ConnectionDict[name].CreateFeatureService();
        }
    }
}
