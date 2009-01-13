#region LGPL Header
// Copyright (C) 2009, Jackie Ng
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
using ICSharpCode.Core;
using FdoToolbox.Core.Feature;

namespace FdoToolbox.Base.Controls
{
    public partial class FdoUnregProviderCtl : UserControl, IViewContent, IFdoUnregProviderView
    {
        private FdoUnregProviderPresenter _presenter;

        public FdoUnregProviderCtl()
        {
            InitializeComponent();
            _presenter = new FdoUnregProviderPresenter(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            _presenter.GetProviders();
            base.OnLoad(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ViewContentClosing(this, EventArgs.Empty);
        }

        public Control ContentControl
        {
            get { return this; }
        }

        public string Title
        {
            get { return ResourceService.GetString("TITLE_UNREGISTER_PROVIDER"); }
        }

        public event EventHandler TitleChanged = delegate { };

        public bool CanClose
        {
            get { return true; }
        }

        public bool Close()
        {
            return true;
        }

        public bool Save()
        {
            return true;
        }

        public bool SaveAs()
        {
            return true;
        }

        public event EventHandler ViewContentClosing = delegate { };

        private void lstProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.SelectionChanged();
        }

        public IList<FdoToolbox.Core.Feature.FdoProviderInfo> ProviderList
        {
            set 
            {
                lstProviders.DisplayMember = "DisplayName";
                lstProviders.DataSource = value; 
            }
        }

        public IList<string> SelectedProviders
        {
            get 
            {
                IList<string> names = new List<string>();
                foreach (object obj in lstProviders.SelectedItems)
                {
                    names.Add((obj as FdoProviderInfo).Name);
                }
                return names;
            }
        }

        public bool UnregEnabled
        {
            set { btnUnregister.Enabled = value; }
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            if (_presenter.Unregister())
            {
                MessageService.ShowMessage(ResourceService.GetString("MSG_PROVIDER_UNREGISTERED"), ResourceService.GetString("TITLE_UNREGISTER_PROVIDER"));
                _presenter.GetProviders();
            }
        }
    }
}