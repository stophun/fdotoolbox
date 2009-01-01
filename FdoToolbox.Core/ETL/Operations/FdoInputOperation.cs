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
using System.Text;
using FdoToolbox.Core.Feature;

namespace FdoToolbox.Core.ETL.Operations
{
    /// <summary>
    /// FDO input pipeline operation
    /// </summary>
    public class FdoInputOperation : FdoOperationBase
    {
        private FdoConnection _conn;

        /// <summary>
        /// Initializes a new instance of the <see cref="FdoInputOperation"/> class.
        /// </summary>
        /// <param name="conn">The conn.</param>
        /// <param name="query">The query.</param>
        public FdoInputOperation(FdoConnection conn, FeatureQueryOptions query)
        {
            _conn = conn;
            this.Query = query;
        }

        private FeatureQueryOptions _Query;

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>The query.</value>
        public FeatureQueryOptions Query
        {
            get { return _Query; }
            set { _Query = value; }
        }

        /// <summary>
        /// Executes the operation
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        public override IEnumerable<FdoRow> Execute(IEnumerable<FdoRow> rows)
        {
            using (FdoFeatureService service = _conn.CreateFeatureService())
            {
                using (FdoFeatureReader reader = service.SelectFeatures(this.Query))
                {
                    while (reader.ReadNext())
                    {
                        yield return CreateRowFromReader(reader);
                    }
                }
            }
        }

        private FdoRow CreateRowFromReader(FdoFeatureReader reader)
        {
            return FdoRow.FromFeatureReader(reader);
        }
    }
}
