using System;
using System.Collections.Generic;
using System.Text;
using FdoToolbox.Express.Controls.Odbc;
using FdoToolbox.Core.Feature;
using FdoToolbox.Base;
using FdoToolbox.Base.Services;
using ICSharpCode.Core;
using FdoToolbox.Core;

namespace FdoToolbox.Express.Controls
{
    public interface IConnectOdbcView
    {
        OdbcType[] OdbcTypes { set; }
        OdbcType SelectedOdbcType { get; }

        IOdbcConnectionBuilder BuilderObject { get; set; }
        string ConnectionName { get; }
    }

    public class ConnectOdbcPresenter
    {
        private readonly IConnectOdbcView _view;

        private Dictionary<OdbcType, IOdbcConnectionBuilder> _builders;

        public ConnectOdbcPresenter(IConnectOdbcView view)
        {
            _view = view;
            _builders = new Dictionary<OdbcType, IOdbcConnectionBuilder>();
            _builders.Add(OdbcType.MsAccess, new OdbcAccess());
            _builders.Add(OdbcType.MsExcel, new OdbcExcel());
            _builders.Add(OdbcType.SQLServer, new OdbcSqlServer());
            _builders.Add(OdbcType.Text, new OdbcText());
            _builders.Add(OdbcType.Generic, new OdbcGeneric());
        }

        public void Init()
        {
            _view.OdbcTypes = (OdbcType[])Enum.GetValues(typeof(OdbcType));
        }

        public void OdbcTypeChanged()
        {
            OdbcType ot = _view.SelectedOdbcType;
            _view.BuilderObject = _builders[ot];
        }

        public bool Connect()
        {
            if (string.IsNullOrEmpty(_view.ConnectionName))
            {
                MessageService.ShowMessage("Name required");
                return false;
            }

            FdoConnection conn = new FdoConnection("OSGeo.ODBC", string.Format("ConnectionString=\"{0}\"", _view.BuilderObject.ToConnectionString()));
            if (conn.Open() == FdoConnectionState.Open)
            {
                IFdoConnectionManager mgr = ServiceManager.Instance.GetService<IFdoConnectionManager>();
                mgr.AddConnection(_view.ConnectionName, conn);
                return true;
            }

            MessageService.ShowMessage("Connection test failed");
            return false;
        }

        public void TestConnection()
        {
            FdoConnection conn = new FdoConnection("OSGeo.ODBC", string.Format("ConnectionString=\"{0}\"", _view.BuilderObject.ToConnectionString()));
            try
            {
                FdoConnectionState state = conn.Open();
                if (state == FdoConnectionState.Open)
                {
                    MessageService.ShowMessage("Test successful");
                    conn.Close();
                }
                else
                {
                    MessageService.ShowError("Connection test failed");
                }
            }
            catch (FdoException ex)
            {
                MessageService.ShowError(ex.InnerException.Message);
            }
        }
    }
}
