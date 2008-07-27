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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OSGeo.FDO.Connections;
using FdoToolbox.Core.Controls;
using OSGeo.FDO.Connections.Capabilities;
using OSGeo.FDO.Schema;
using OSGeo.FDO.Expression;
using OSGeo.FDO.Filter;

namespace FdoToolbox.Core.Forms
{
    public partial class ExpressionDlg : Form, IConnectionBoundCtl
    {
        private IConnection _BoundConnection;

        private ClassDefinition _ClassDef;

        private ExpressionMode _ExprMode;

        internal ExpressionDlg()
        {
            InitializeComponent();
            _FunctionMenuItems = new Dictionary<FunctionCategoryType, ToolStripMenuItem>();
            _ExprMode = ExpressionMode.Filter;
        }

        public ExpressionDlg(IConnection conn, ClassDefinition classDef, ExpressionMode mode)
            : this()
        {
            _BoundConnection = conn;
            _ClassDef = classDef;
            _ExprMode = mode;
        }

        public IConnection BoundConnection
        {
            get { return _BoundConnection; }
        }

        private Dictionary<FunctionCategoryType, ToolStripMenuItem> _FunctionMenuItems;

        protected override void OnLoad(EventArgs e)
        {
            if(this.BoundConnection != null)
            {   
                FunctionDefinitionCollection funcs = this.BoundConnection.ExpressionCapabilities.Functions;
                Array categories = Enum.GetValues(typeof(FunctionCategoryType));
                ConditionType[] conditions = this.BoundConnection.FilterCapabilities.ConditionTypes;
                DistanceOperations[] distanceOps = this.BoundConnection.FilterCapabilities.DistanceOperations;
                SpatialOperations[] spatialOps = this.BoundConnection.FilterCapabilities.SpatialOperations;
                LoadFunctionCategories(categories);
                LoadFunctionDefinitions(funcs);
                LoadProperties();
                LoadConditionTypes(conditions);
                LoadDistanceOperations(distanceOps);
                LoadSpatialOperations(spatialOps);
                ApplyView();
            }
            base.OnLoad(e);
        }

        private void ApplyView()
        {
            btnConditions.Visible = (_ExprMode == ExpressionMode.Filter && btnConditions.DropDown.Items.Count > 0);
            btnDistance.Visible = (_ExprMode == ExpressionMode.Filter && btnDistance.DropDown.Items.Count > 0);
            btnSpatial.Visible = (_ExprMode == ExpressionMode.Filter && btnSpatial.DropDown.Items.Count > 0);

            if (_ExprMode == ExpressionMode.SelectAggregates)
            {
                foreach (FunctionCategoryType ctype in _FunctionMenuItems.Keys)
                {
                    _FunctionMenuItems[ctype].Visible = (ctype == FunctionCategoryType.FunctionCategoryType_Aggregate);
                }
            }
            else
            {
                foreach (FunctionCategoryType ctype in _FunctionMenuItems.Keys)
                {
                    _FunctionMenuItems[ctype].Visible = (ctype != FunctionCategoryType.FunctionCategoryType_Aggregate);
                }
            }
        }

        private void LoadSpatialOperations(SpatialOperations[] spatialOps)
        {
            btnSpatial.Visible = (spatialOps.Length > 0);
            foreach (SpatialOperations op in spatialOps)
            {
                ToolStripMenuItem item = null;
                switch (op)
                {
                    case SpatialOperations.SpatialOperations_Contains:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Contains";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_CoveredBy:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Covered By";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_Crosses:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Crosses";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_Disjoint:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Disjoint";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_EnvelopeIntersects:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Envelope Intersects";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_Equals:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Equals";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_Inside:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Inside";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_Intersects:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Intersects";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_Overlaps:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Overlaps";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_Touches:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Touches";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case SpatialOperations.SpatialOperations_Within:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Within";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                }
                if (item != null)
                    btnSpatial.DropDown.Items.Add(item);
            }
        }

        private void LoadDistanceOperations(DistanceOperations[] distanceOps)
        {
            btnDistance.Visible = (distanceOps.Length > 0);
            foreach (DistanceOperations op in distanceOps)
            {
                ToolStripMenuItem item = null;
                switch (op)
                {
                    case DistanceOperations.DistanceOperations_Beyond:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Beyond";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                    case DistanceOperations.DistanceOperations_Within:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Within";
                            item.Tag = op;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implemented", "Not Implemented"); };
                        }
                        break;
                }
                if (item != null)
                    btnDistance.DropDown.Items.Add(item);
            }
        }

        private void LoadConditionTypes(ConditionType[] conditions)
        {
            btnConditions.Visible = (conditions.Length > 0);
            foreach (ConditionType cond in conditions)
            {
                ToolStripMenuItem item = null;
                switch (cond)
                {
                    case ConditionType.ConditionType_Comparison:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Comparison";
                            item.Tag = cond;
                            item.DropDown.Items.Add("=", null, delegate(object sender, EventArgs e) { InsertText(" <property> = <value> "); });
                            item.DropDown.Items.Add(">", null, delegate(object sender, EventArgs e) { InsertText(" <property> > <value> "); });
                            item.DropDown.Items.Add("<", null, delegate(object sender, EventArgs e) { InsertText(" <property> < <value> "); });
                            item.DropDown.Items.Add("<>", null, delegate(object sender, EventArgs e) { InsertText(" <property> <> <value> "); });
                            item.DropDown.Items.Add("<=", null, delegate(object sender, EventArgs e) { InsertText(" <property> <= <value> "); });
                            item.DropDown.Items.Add(">=", null, delegate(object sender, EventArgs e) { InsertText(" <property> >= <value> "); });
                        }
                        break;
                    case ConditionType.ConditionType_Distance:
                        {
                            //Not supported atm
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Distance";
                            item.Tag = cond;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implented", "Not Implemented"); };
                        }
                        break;
                    case ConditionType.ConditionType_In:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "In";
                            item.Tag = cond;
                            item.Click += delegate(object sender, EventArgs e) { InsertText(" <property> IN ( <comma-separated value list> ) "); };
                        }
                        break;
                    case ConditionType.ConditionType_Like:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Like";
                            item.Tag = cond;
                            item.Click += delegate(object sender, EventArgs e) { InsertText(" <property> LIKE <pattern> "); };
                        }
                        break;
                    case ConditionType.ConditionType_Null:
                        {
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Null";
                            item.Tag = cond;
                            item.Click += delegate(object sender, EventArgs e) { InsertText(" <property> NULL "); };
                        }
                        break;
                    case ConditionType.ConditionType_Spatial:
                        {
                            //Not supported atm
                            item = new ToolStripMenuItem();
                            item.Text = item.Name = "Spatial";
                            item.Tag = cond;
                            item.Click += delegate(object sender, EventArgs e) { AppConsole.Alert("Not Implented", "Not Implemented"); };
                        }
                        break;
                }
                if (item != null)
                    btnConditions.DropDown.Items.Add(item);
            }
        }

        private void LoadProperties()
        {
            foreach (PropertyDefinition propDef in _ClassDef.Properties)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = item.Name = propDef.Name;
                switch (propDef.PropertyType)
                {
                    case PropertyType.PropertyType_AssociationProperty:
                        item.Image = Properties.Resources.table_relationship;
                        break;
                    case PropertyType.PropertyType_DataProperty:
                        item.Image = Properties.Resources.table;
                        break;
                    case PropertyType.PropertyType_GeometricProperty:
                        item.Image = Properties.Resources.shape_handles;
                        break;
                    case PropertyType.PropertyType_ObjectProperty:
                        item.Image = Properties.Resources.package;
                        break;
                    case PropertyType.PropertyType_RasterProperty:
                        item.Image = Properties.Resources.image;
                        break;
                }
                item.Click += new EventHandler(property_Click);
                btnProperties.DropDown.Items.Add(item);
            }
        }

        private void LoadFunctionDefinitions(FunctionDefinitionCollection funcs)
        {
            foreach (FunctionDefinition funcDef in funcs)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = item.Name = funcDef.Name;
                item.ToolTipText = funcDef.Description;
                item.Tag = funcDef;
                item.Click += new EventHandler(function_Click);
                _FunctionMenuItems[funcDef.FunctionCategoryType].DropDown.Items.Add(item);
            }
        }

        private void LoadFunctionCategories(Array categories)
        {
            foreach (object category in categories)
            {
                string name = string.Empty;
                FunctionCategoryType funcCat = (FunctionCategoryType)category;
                switch (funcCat)
                {
                    case FunctionCategoryType.FunctionCategoryType_Aggregate:
                        name = "Aggregate";
                        break;
                    case FunctionCategoryType.FunctionCategoryType_Conversion:
                        name = "Conversion";
                        break;
                    case FunctionCategoryType.FunctionCategoryType_Custom:
                        name = "Custom";
                        break;
                    case FunctionCategoryType.FunctionCategoryType_Date:
                        name = "Date";
                        break;
                    case FunctionCategoryType.FunctionCategoryType_Geometry:
                        name = "Geometry";
                        break;
                    case FunctionCategoryType.FunctionCategoryType_Math:
                        name = "Math";
                        break;
                    case FunctionCategoryType.FunctionCategoryType_Numeric:
                        name = "Numeric";
                        break;
                    case FunctionCategoryType.FunctionCategoryType_String:
                        name = "String";
                        break;
                    case FunctionCategoryType.FunctionCategoryType_Unspecified:
                        name = "Unspecified";
                        break;
                }
                if (!string.IsNullOrEmpty(name))
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Name = item.Text = name;
                    _FunctionMenuItems.Add(funcCat, item);
                    btnFunctions.DropDown.Items.Add(item);
                }
            }
        }

        void property_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                string exprText = item.Name;
                InsertText(exprText);
            }
        }

        private void InsertText(string exprText)
        {
            int index = txtExpression.SelectionStart;
            if (txtExpression.SelectionLength > 0)
            {
                txtExpression.SelectedText = exprText;
                txtExpression.SelectionStart = index;
            }
            else
            {
                if (index > 0)
                {
                    string text = txtExpression.Text;
                    txtExpression.Text = text.Insert(index, exprText);
                    txtExpression.SelectionStart = index;
                }
                else
                {
                    txtExpression.Text = exprText;
                    txtExpression.SelectionStart = index;
                }
            }
        }

        void function_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                FunctionDefinition funcDef = item.Tag as FunctionDefinition;
                string funcTemplate = "{0}({1})";
                List<string> parameters = new List<string>();
                foreach (ArgumentDefinition argDef in funcDef.Arguments)
                {
                    parameters.Add("<"+argDef.Name+">");
                }
                string exprText = string.Format(funcTemplate, funcDef.Name, string.Join(", ", parameters.ToArray()));
                InsertText(exprText);
            }
        }

        public static string EditExpression(IConnection conn, ClassDefinition classDef, string expr, ExpressionMode mode)
        {
            ExpressionDlg dlg = new ExpressionDlg(conn, classDef, mode);
            dlg.txtExpression.Text = expr;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.txtExpression.Text;
            }
            return null;
        }

        public static string NewExpression(IConnection conn, ClassDefinition classDef, ExpressionMode mode)
        {
            ExpressionDlg dlg = new ExpressionDlg(conn, classDef, mode);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.txtExpression.Text;
            }
            return null;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (ValidateExpression())
            {
                AppConsole.Alert("Validate Expression", "Expression is valid");
            }
        }

        private bool ValidateExpression()
        {
            bool valid = true;
            try
            {
                if (!string.IsNullOrEmpty(txtExpression.Text))
                {
                    using (Expression expr = Expression.Parse(txtExpression.Text))
                    {
                        valid = true;
                    }
                }
            }
            catch (OSGeo.FDO.Common.Exception ex)
            {
                AppConsole.Alert("Error Validating Expression", ex.Message);
                valid = false;
            }
            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateExpression())
                this.DialogResult = DialogResult.OK;
        }
    }

    public enum ExpressionMode
    {
        Filter,
        SelectAggregates
    }
}