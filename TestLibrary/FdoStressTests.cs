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
using NUnit.Framework;
using OSGeo.FDO.Commands.Feature;
using OSGeo.FDO.Connections;
using OSGeo.FDO.Schema;
using FdoToolbox.Core.ClientServices;
using OSGeo.FDO.Geometry;
using OSGeo.FDO.Expression;
using OSGeo.FDO.Commands;
using OSGeo.FDO.Common;
using FdoToolbox.Core;
using System.IO;
using FdoToolbox.Core.Utility;

namespace FdoToolbox.Tests
{
    /*
     This test suite stress tests the FDO API mainly in the area
     of data insertion and retrieval.
     
     These tests will take time to execute and may not be guaranteed 
     to pass.
     
     This test suite is not run by default in the TestRunner.exe
     */

    [TestFixture(Description = "FDO API Stress Tests")]
    [Category("Stress")]
    [Explicit]
    public class FdoStressTests : BaseTest
    {
        [Test]
        public void TestPropertyDefinitionCollection()
        {
            Class cls = new Class("Test", "Test");

            DataPropertyDefinition id = new DataPropertyDefinition("ID", "");
            id.DataType = DataType.DataType_Int32;
            id.IsAutoGenerated = true;
            id.ReadOnly = true;

            cls.Properties.Add(id);
            cls.IdentityProperties.Add(id);

            DataPropertyDefinition name = new DataPropertyDefinition("Name", "");
            name.DataType = DataType.DataType_String;
            name.Length = 100;
            name.Nullable = true;

            cls.Properties.Add(name);

            for (int i = 0; i < int.MaxValue; i++)
            {
                for (int j = 0; j < cls.Properties.Count; j++)
                {
                    PropertyDefinition pd = cls.Properties[j];
                    string propName = pd.Name;
                }
            }
        }
    }
}