﻿#region LGPL Header
// Copyright (C) 2011, Jackie Ng
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
//
// See license.txt for more/additional licensing information
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FdoToolbox.Base.Controls;
using ICSharpCode.Core;

namespace FdoToolbox.Express.Controls
{
    public partial class ConnectKingOracleCtl : ViewContent, IConnectKingOracleView
    {
        private ConnectKingOraclePresenter _presenter;

        public ConnectKingOracleCtl()
        {
            InitializeComponent();
            _presenter = new ConnectKingOraclePresenter(this);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (_presenter.Connect())
                this.Close();
        }

        public override string Title
        {
            get { return ResourceService.GetString("TITLE_CONNECT_KINGORACLE"); }
        }

        #region IConnectKingOracleView Members

        public string Username
        {
            get { return txtUsername.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        public string Service
        {
            get { return txtService.Text; }
        }

        public string OracleSchema
        {
            get { return txtOracleSchema.Text; }
        }

        public string KingFdoClass
        {
            get { return txtKingFdoClass.Text; }
        }

        public string SdeSchema
        {
            get { return txtSdeSchema.Text; }
        }

        public string ConnectionName
        {
            get { return txtConnectionName.Text; }
        }

        #endregion
    }
}
