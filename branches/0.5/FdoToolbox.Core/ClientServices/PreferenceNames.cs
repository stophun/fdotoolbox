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

namespace FdoToolbox.Core.ClientServices
{
    /// <summary>
    /// Master preference name list
    /// </summary>
    public class PreferenceNames
    {
        #region string preferences
        public const string PREF_STR_WORKING_DIRECTORY = "pref_str_working_dir";
        public const string PREF_STR_FDO_HOME = "pref_str_fdo_home";
        #endregion

        #region integer preferences
        #endregion

        #region double preferences
        #endregion

        #region boolean preferences
        public const string PREF_BOOL_TIMESTAMP_CONSOLE = "pref_bool_timestamp_console";
        #endregion
    }
}
