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
using FdoToolbox.Core;
using OSGeo.FDO.Connections;

namespace FdoInfo
{
    public class ListDataStoresCommand : ConnectionCommand
    {
        private bool _FdoOnly;

        public ListDataStoresCommand(string provider, string connStr, bool fdoOnly)
            : base(provider, connStr)
        {
            _FdoOnly = fdoOnly;
        }

        public override int Execute()
        {
            IConnection conn = null;
            try
            {
                conn = CreateConnection();
                conn.Open();
            }
            catch (OSGeo.FDO.Common.Exception ex)
            {
                WriteException(ex);
                return (int)CommandStatus.E_FAIL_CONNECT;
            }

            using (FeatureService service = new FeatureService(conn))
            {
                List<DataStoreInfo> datastores = service.ListDataStores(_FdoOnly);
                AppConsole.WriteLine("Listing datastores:\n");
                foreach (DataStoreInfo dstore in datastores)
                {
                    AppConsole.WriteLine("\n\tName:{0}\n\tDescription:{1}", dstore.Name, dstore.Description);
                }
            }

            conn.Close();
            return (int)CommandStatus.E_OK;
        }
    }
}
