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
using FdoToolbox.Core.Feature;
using OSGeo.FDO.ClientServices;

namespace FdoToolbox.Base.Controls.PreferenceSheets
{
    public partial class ProviderPreferencesCtl : UserControl, IPreferenceSheet
    {
        public ProviderPreferencesCtl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            string[] ignore = Preferences.ExcludePartialSchemaProviders;
            IList<FdoProviderInfo> providers = FdoFeatureService.GetProviders();
            foreach (FdoProviderInfo prv in providers)
            {
                ProviderNameTokens pnt = new ProviderNameTokens(prv.Name);
                string [] tokens = pnt.GetNameTokens();
                chkIgnore.Items.Add(tokens[0] + "." + tokens[1]);
            }
            foreach (string ign in ignore)
            {
                int idx = chkIgnore.Items.IndexOf(ign);
                if (idx >= 0)
                    chkIgnore.SetItemChecked(idx, true);
            }
            base.OnLoad(e);
        }

        public string Title
        {
            get { return "Providers"; }
        }

        public Control ContentControl
        {
            get { return this; }
        }

        public void ApplyChanges()
        {
            List<string> providers = new List<string>();
            foreach (object item in chkIgnore.CheckedItems)
            {
                providers.Add(item.ToString());
            }
            Preferences.ExcludePartialSchemaProviders = providers.ToArray();
        }
    }
}
