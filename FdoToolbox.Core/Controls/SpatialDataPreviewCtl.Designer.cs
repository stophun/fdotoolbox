namespace FdoToolbox.Core.Controls
{
    partial class SpatialDataPreviewCtl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpatialDataPreviewCtl));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkMap = new System.Windows.Forms.CheckBox();
            this.splitSave = new FdoToolbox.Core.Controls.SplitButton();
            this.ctxSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToSDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.grpQuery = new System.Windows.Forms.GroupBox();
            this.tabQueryMode = new System.Windows.Forms.TabControl();
            this.pageStandard = new System.Windows.Forms.TabPage();
            this.numLimit = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdComputedFields = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddComputedField = new System.Windows.Forms.Button();
            this.btnClearComputedFields = new System.Windows.Forms.Button();
            this.btnDeleteComputedField = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPropertyNames = new System.Windows.Forms.CheckedListBox();
            this.btnUncheckAllProperties = new System.Windows.Forms.Button();
            this.btnCheckAllProperties = new System.Windows.Forms.Button();
            this.btnEditFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSchema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageAggregates = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdExpressions = new System.Windows.Forms.DataGridView();
            this.COL_EXPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_ALIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDistinct = new System.Windows.Forms.CheckBox();
            this.btnAddExpr = new System.Windows.Forms.Button();
            this.btnDeleteExpr = new System.Windows.Forms.Button();
            this.btnClearAggregates = new System.Windows.Forms.Button();
            this.btnAggFilter = new System.Windows.Forms.Button();
            this.txtAggFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAggSchema = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAggClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pageSQL = new System.Windows.Forms.TabPage();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.tabResults = new System.Windows.Forms.TabControl();
            this.TAB_RESULTS_GRID = new System.Windows.Forms.TabPage();
            this.grdPreview = new System.Windows.Forms.DataGridView();
            this.TAB_RESULTS_MAP = new System.Windows.Forms.TabPage();
            this.mapCtl = new FdoToolbox.Core.Controls.MapPreviewCtl();
            this.imgPreview = new System.Windows.Forms.ImageList(this.components);
            this.bgStandard = new System.ComponentModel.BackgroundWorker();
            this.bgSql = new System.ComponentModel.BackgroundWorker();
            this.saveQueryDlg = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ctxSave.SuspendLayout();
            this.grpQuery.SuspendLayout();
            this.tabQueryMode.SuspendLayout();
            this.pageStandard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComputedFields)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pageAggregates.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpressions)).BeginInit();
            this.pageSQL.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.TAB_RESULTS_GRID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPreview)).BeginInit();
            this.TAB_RESULTS_MAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkMap);
            this.splitContainer1.Panel1.Controls.Add(this.splitSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel1.Controls.Add(this.lblCount);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer1.Panel1.Controls.Add(this.grpQuery);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabResults);
            this.splitContainer1.Size = new System.Drawing.Size(494, 395);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkMap
            // 
            this.chkMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMap.AutoSize = true;
            this.chkMap.Checked = true;
            this.chkMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMap.Location = new System.Drawing.Point(142, 249);
            this.chkMap.Name = "chkMap";
            this.chkMap.Size = new System.Drawing.Size(47, 17);
            this.chkMap.TabIndex = 6;
            this.chkMap.Text = "Map";
            this.chkMap.UseVisualStyleBackColor = true;
            this.chkMap.CheckedChanged += new System.EventHandler(this.chkMap_CheckedChanged);
            // 
            // splitSave
            // 
            this.splitSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.splitSave.AutoSize = true;
            this.splitSave.ContextMenuStrip = this.ctxSave;
            this.splitSave.Location = new System.Drawing.Point(195, 245);
            this.splitSave.Name = "splitSave";
            this.splitSave.Size = new System.Drawing.Size(87, 23);
            this.splitSave.TabIndex = 5;
            this.splitSave.Text = "Save Query";
            this.splitSave.UseVisualStyleBackColor = true;
            // 
            // ctxSave
            // 
            this.ctxSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToSDFToolStripMenuItem});
            this.ctxSave.Name = "ctxSave";
            this.ctxSave.Size = new System.Drawing.Size(134, 26);
            // 
            // saveToSDFToolStripMenuItem
            // 
            this.saveToSDFToolStripMenuItem.Image = global::FdoToolbox.Core.Properties.Resources.disk;
            this.saveToSDFToolStripMenuItem.Name = "saveToSDFToolStripMenuItem";
            this.saveToSDFToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToSDFToolStripMenuItem.Text = "Save to SDF";
            this.saveToSDFToolStripMenuItem.Click += new System.EventHandler(this.saveToSDFToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::FdoToolbox.Core.Properties.Resources.cross;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(341, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(10, 250);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(411, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Grid";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Image = global::FdoToolbox.Core.Properties.Resources.application_go;
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(288, 245);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(47, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Go";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // grpQuery
            // 
            this.grpQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQuery.Controls.Add(this.tabQueryMode);
            this.grpQuery.Location = new System.Drawing.Point(3, 3);
            this.grpQuery.Name = "grpQuery";
            this.grpQuery.Size = new System.Drawing.Size(486, 239);
            this.grpQuery.TabIndex = 0;
            this.grpQuery.TabStop = false;
            this.grpQuery.Text = "Data Query Parameters";
            // 
            // tabQueryMode
            // 
            this.tabQueryMode.Controls.Add(this.pageStandard);
            this.tabQueryMode.Controls.Add(this.pageAggregates);
            this.tabQueryMode.Controls.Add(this.pageSQL);
            this.tabQueryMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQueryMode.Location = new System.Drawing.Point(3, 16);
            this.tabQueryMode.Name = "tabQueryMode";
            this.tabQueryMode.SelectedIndex = 0;
            this.tabQueryMode.Size = new System.Drawing.Size(480, 220);
            this.tabQueryMode.TabIndex = 0;
            this.tabQueryMode.SelectedIndexChanged += new System.EventHandler(this.tabQueryMode_SelectedIndexChanged);
            // 
            // pageStandard
            // 
            this.pageStandard.Controls.Add(this.numLimit);
            this.pageStandard.Controls.Add(this.groupBox3);
            this.pageStandard.Controls.Add(this.groupBox2);
            this.pageStandard.Controls.Add(this.btnEditFilter);
            this.pageStandard.Controls.Add(this.txtFilter);
            this.pageStandard.Controls.Add(this.label4);
            this.pageStandard.Controls.Add(this.label3);
            this.pageStandard.Controls.Add(this.cmbClass);
            this.pageStandard.Controls.Add(this.label2);
            this.pageStandard.Controls.Add(this.cmbSchema);
            this.pageStandard.Controls.Add(this.label1);
            this.pageStandard.Location = new System.Drawing.Point(4, 22);
            this.pageStandard.Name = "pageStandard";
            this.pageStandard.Padding = new System.Windows.Forms.Padding(3);
            this.pageStandard.Size = new System.Drawing.Size(472, 194);
            this.pageStandard.TabIndex = 0;
            this.pageStandard.Text = "Standard";
            this.pageStandard.UseVisualStyleBackColor = true;
            // 
            // numLimit
            // 
            this.numLimit.Location = new System.Drawing.Point(58, 32);
            this.numLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLimit.Name = "numLimit";
            this.numLimit.Size = new System.Drawing.Size(57, 20);
            this.numLimit.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.grdComputedFields);
            this.groupBox3.Controls.Add(this.btnAddComputedField);
            this.groupBox3.Controls.Add(this.btnClearComputedFields);
            this.groupBox3.Controls.Add(this.btnDeleteComputedField);
            this.groupBox3.Location = new System.Drawing.Point(3, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 122);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Computed Fields";
            // 
            // grdComputedFields
            // 
            this.grdComputedFields.AllowUserToAddRows = false;
            this.grdComputedFields.AllowUserToDeleteRows = false;
            this.grdComputedFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdComputedFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdComputedFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grdComputedFields.Location = new System.Drawing.Point(6, 19);
            this.grdComputedFields.Name = "grdComputedFields";
            this.grdComputedFields.RowHeadersVisible = false;
            this.grdComputedFields.Size = new System.Drawing.Size(274, 68);
            this.grdComputedFields.TabIndex = 9;
            this.grdComputedFields.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdComputedFields_CellContentClick);
            this.grdComputedFields.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdComputedFields_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Expression";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Alias";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnAddComputedField
            // 
            this.btnAddComputedField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddComputedField.Image = global::FdoToolbox.Core.Properties.Resources.add;
            this.btnAddComputedField.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddComputedField.Location = new System.Drawing.Point(6, 93);
            this.btnAddComputedField.Name = "btnAddComputedField";
            this.btnAddComputedField.Size = new System.Drawing.Size(56, 23);
            this.btnAddComputedField.TabIndex = 11;
            this.btnAddComputedField.Text = "Add";
            this.btnAddComputedField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddComputedField.UseVisualStyleBackColor = true;
            this.btnAddComputedField.Click += new System.EventHandler(this.btnAddComputedField_Click);
            // 
            // btnClearComputedFields
            // 
            this.btnClearComputedFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearComputedFields.Enabled = false;
            this.btnClearComputedFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearComputedFields.Location = new System.Drawing.Point(135, 93);
            this.btnClearComputedFields.Name = "btnClearComputedFields";
            this.btnClearComputedFields.Size = new System.Drawing.Size(59, 23);
            this.btnClearComputedFields.TabIndex = 13;
            this.btnClearComputedFields.Text = "Clear";
            this.btnClearComputedFields.UseVisualStyleBackColor = true;
            this.btnClearComputedFields.Click += new System.EventHandler(this.btnClearComputedFields_Click);
            // 
            // btnDeleteComputedField
            // 
            this.btnDeleteComputedField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteComputedField.Enabled = false;
            this.btnDeleteComputedField.Image = global::FdoToolbox.Core.Properties.Resources.cross;
            this.btnDeleteComputedField.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteComputedField.Location = new System.Drawing.Point(68, 93);
            this.btnDeleteComputedField.Name = "btnDeleteComputedField";
            this.btnDeleteComputedField.Size = new System.Drawing.Size(61, 23);
            this.btnDeleteComputedField.TabIndex = 12;
            this.btnDeleteComputedField.Text = "Delete";
            this.btnDeleteComputedField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteComputedField.UseVisualStyleBackColor = true;
            this.btnDeleteComputedField.Click += new System.EventHandler(this.btnDeleteComputedField_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkPropertyNames);
            this.groupBox2.Controls.Add(this.btnUncheckAllProperties);
            this.groupBox2.Controls.Add(this.btnCheckAllProperties);
            this.groupBox2.Location = new System.Drawing.Point(295, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 122);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property Names";
            // 
            // chkPropertyNames
            // 
            this.chkPropertyNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPropertyNames.FormattingEnabled = true;
            this.chkPropertyNames.Location = new System.Drawing.Point(8, 19);
            this.chkPropertyNames.Name = "chkPropertyNames";
            this.chkPropertyNames.Size = new System.Drawing.Size(157, 64);
            this.chkPropertyNames.TabIndex = 15;
            // 
            // btnUncheckAllProperties
            // 
            this.btnUncheckAllProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUncheckAllProperties.Location = new System.Drawing.Point(90, 93);
            this.btnUncheckAllProperties.Name = "btnUncheckAllProperties";
            this.btnUncheckAllProperties.Size = new System.Drawing.Size(75, 23);
            this.btnUncheckAllProperties.TabIndex = 17;
            this.btnUncheckAllProperties.Text = "Uncheck All";
            this.btnUncheckAllProperties.UseVisualStyleBackColor = true;
            this.btnUncheckAllProperties.Click += new System.EventHandler(this.btnUncheckAllProperties_Click);
            // 
            // btnCheckAllProperties
            // 
            this.btnCheckAllProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckAllProperties.Location = new System.Drawing.Point(8, 93);
            this.btnCheckAllProperties.Name = "btnCheckAllProperties";
            this.btnCheckAllProperties.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAllProperties.TabIndex = 16;
            this.btnCheckAllProperties.Text = "Check All";
            this.btnCheckAllProperties.UseVisualStyleBackColor = true;
            this.btnCheckAllProperties.Click += new System.EventHandler(this.btnCheckAllProperties_Click);
            // 
            // btnEditFilter
            // 
            this.btnEditFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFilter.Location = new System.Drawing.Point(438, 32);
            this.btnEditFilter.Name = "btnEditFilter";
            this.btnEditFilter.Size = new System.Drawing.Size(28, 20);
            this.btnEditFilter.TabIndex = 8;
            this.btnEditFilter.Text = "...";
            this.btnEditFilter.UseVisualStyleBackColor = true;
            this.btnEditFilter.Click += new System.EventHandler(this.btnEditFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(156, 33);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(276, 20);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Limit";
            // 
            // cmbClass
            // 
            this.cmbClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClass.DisplayMember = "Name";
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(264, 6);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(202, 21);
            this.cmbClass.TabIndex = 3;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // cmbSchema
            // 
            this.cmbSchema.DisplayMember = "Name";
            this.cmbSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchema.FormattingEnabled = true;
            this.cmbSchema.Location = new System.Drawing.Point(58, 6);
            this.cmbSchema.Name = "cmbSchema";
            this.cmbSchema.Size = new System.Drawing.Size(162, 21);
            this.cmbSchema.TabIndex = 1;
            this.cmbSchema.SelectedIndexChanged += new System.EventHandler(this.cmbSchema_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schema";
            // 
            // pageAggregates
            // 
            this.pageAggregates.Controls.Add(this.groupBox4);
            this.pageAggregates.Controls.Add(this.btnAggFilter);
            this.pageAggregates.Controls.Add(this.txtAggFilter);
            this.pageAggregates.Controls.Add(this.label7);
            this.pageAggregates.Controls.Add(this.cmbAggSchema);
            this.pageAggregates.Controls.Add(this.label6);
            this.pageAggregates.Controls.Add(this.cmbAggClass);
            this.pageAggregates.Controls.Add(this.label5);
            this.pageAggregates.Location = new System.Drawing.Point(4, 22);
            this.pageAggregates.Name = "pageAggregates";
            this.pageAggregates.Padding = new System.Windows.Forms.Padding(3);
            this.pageAggregates.Size = new System.Drawing.Size(472, 194);
            this.pageAggregates.TabIndex = 1;
            this.pageAggregates.Text = "Aggregates";
            this.pageAggregates.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.grdExpressions);
            this.groupBox4.Controls.Add(this.chkDistinct);
            this.groupBox4.Controls.Add(this.btnAddExpr);
            this.groupBox4.Controls.Add(this.btnDeleteExpr);
            this.groupBox4.Controls.Add(this.btnClearAggregates);
            this.groupBox4.Location = new System.Drawing.Point(9, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(445, 128);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aggregate Expressions";
            // 
            // grdExpressions
            // 
            this.grdExpressions.AllowUserToAddRows = false;
            this.grdExpressions.AllowUserToDeleteRows = false;
            this.grdExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdExpressions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpressions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_EXPR,
            this.COL_ALIAS});
            this.grdExpressions.Location = new System.Drawing.Point(6, 19);
            this.grdExpressions.Name = "grdExpressions";
            this.grdExpressions.Size = new System.Drawing.Size(433, 76);
            this.grdExpressions.TabIndex = 6;
            this.grdExpressions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExpressions_CellContentClick);
            this.grdExpressions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExpressions_CellContentClick);
            // 
            // COL_EXPR
            // 
            this.COL_EXPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COL_EXPR.HeaderText = "Expression";
            this.COL_EXPR.Name = "COL_EXPR";
            this.COL_EXPR.ReadOnly = true;
            // 
            // COL_ALIAS
            // 
            this.COL_ALIAS.HeaderText = "Alias";
            this.COL_ALIAS.Name = "COL_ALIAS";
            // 
            // chkDistinct
            // 
            this.chkDistinct.AutoSize = true;
            this.chkDistinct.Location = new System.Drawing.Point(203, 103);
            this.chkDistinct.Name = "chkDistinct";
            this.chkDistinct.Size = new System.Drawing.Size(61, 17);
            this.chkDistinct.TabIndex = 5;
            this.chkDistinct.Text = "Distinct";
            this.chkDistinct.UseVisualStyleBackColor = true;
            // 
            // btnAddExpr
            // 
            this.btnAddExpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddExpr.Image = global::FdoToolbox.Core.Properties.Resources.add;
            this.btnAddExpr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExpr.Location = new System.Drawing.Point(6, 99);
            this.btnAddExpr.Name = "btnAddExpr";
            this.btnAddExpr.Size = new System.Drawing.Size(55, 23);
            this.btnAddExpr.TabIndex = 7;
            this.btnAddExpr.Text = "Add";
            this.btnAddExpr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddExpr.UseVisualStyleBackColor = true;
            this.btnAddExpr.Click += new System.EventHandler(this.btnAddExpr_Click);
            // 
            // btnDeleteExpr
            // 
            this.btnDeleteExpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteExpr.Enabled = false;
            this.btnDeleteExpr.Image = global::FdoToolbox.Core.Properties.Resources.cross;
            this.btnDeleteExpr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteExpr.Location = new System.Drawing.Point(67, 99);
            this.btnDeleteExpr.Name = "btnDeleteExpr";
            this.btnDeleteExpr.Size = new System.Drawing.Size(63, 23);
            this.btnDeleteExpr.TabIndex = 9;
            this.btnDeleteExpr.Text = "Delete";
            this.btnDeleteExpr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteExpr.UseVisualStyleBackColor = true;
            this.btnDeleteExpr.Click += new System.EventHandler(this.btnDeleteExpr_Click);
            // 
            // btnClearAggregates
            // 
            this.btnClearAggregates.Location = new System.Drawing.Point(136, 101);
            this.btnClearAggregates.Name = "btnClearAggregates";
            this.btnClearAggregates.Size = new System.Drawing.Size(59, 23);
            this.btnClearAggregates.TabIndex = 10;
            this.btnClearAggregates.Text = "Clear";
            this.btnClearAggregates.UseVisualStyleBackColor = true;
            this.btnClearAggregates.Click += new System.EventHandler(this.btnClearAggregates_Click);
            // 
            // btnAggFilter
            // 
            this.btnAggFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAggFilter.Location = new System.Drawing.Point(424, 32);
            this.btnAggFilter.Name = "btnAggFilter";
            this.btnAggFilter.Size = new System.Drawing.Size(30, 23);
            this.btnAggFilter.TabIndex = 13;
            this.btnAggFilter.Text = "...";
            this.btnAggFilter.UseVisualStyleBackColor = true;
            this.btnAggFilter.Click += new System.EventHandler(this.btnAggFilter_Click);
            // 
            // txtAggFilter
            // 
            this.txtAggFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAggFilter.Location = new System.Drawing.Point(41, 34);
            this.txtAggFilter.Name = "txtAggFilter";
            this.txtAggFilter.Size = new System.Drawing.Size(377, 20);
            this.txtAggFilter.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Filter";
            // 
            // cmbAggSchema
            // 
            this.cmbAggSchema.DisplayMember = "Name";
            this.cmbAggSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAggSchema.FormattingEnabled = true;
            this.cmbAggSchema.Location = new System.Drawing.Point(97, 7);
            this.cmbAggSchema.Name = "cmbAggSchema";
            this.cmbAggSchema.Size = new System.Drawing.Size(121, 21);
            this.cmbAggSchema.TabIndex = 4;
            this.cmbAggSchema.SelectedIndexChanged += new System.EventHandler(this.cmbAggSchema_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Feature Schema";
            // 
            // cmbAggClass
            // 
            this.cmbAggClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAggClass.DisplayMember = "Name";
            this.cmbAggClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAggClass.FormattingEnabled = true;
            this.cmbAggClass.Location = new System.Drawing.Point(310, 7);
            this.cmbAggClass.Name = "cmbAggClass";
            this.cmbAggClass.Size = new System.Drawing.Size(144, 21);
            this.cmbAggClass.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Feature Class";
            // 
            // pageSQL
            // 
            this.pageSQL.Controls.Add(this.txtSQL);
            this.pageSQL.Location = new System.Drawing.Point(4, 22);
            this.pageSQL.Name = "pageSQL";
            this.pageSQL.Size = new System.Drawing.Size(472, 194);
            this.pageSQL.TabIndex = 2;
            this.pageSQL.Text = "SQL";
            this.pageSQL.UseVisualStyleBackColor = true;
            // 
            // txtSQL
            // 
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(472, 194);
            this.txtSQL.TabIndex = 0;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.TAB_RESULTS_GRID);
            this.tabResults.Controls.Add(this.TAB_RESULTS_MAP);
            this.tabResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabResults.ImageList = this.imgPreview;
            this.tabResults.Location = new System.Drawing.Point(0, 0);
            this.tabResults.Name = "tabResults";
            this.tabResults.SelectedIndex = 0;
            this.tabResults.Size = new System.Drawing.Size(492, 114);
            this.tabResults.TabIndex = 0;
            // 
            // TAB_RESULTS_GRID
            // 
            this.TAB_RESULTS_GRID.Controls.Add(this.grdPreview);
            this.TAB_RESULTS_GRID.ImageKey = "application_view_columns.png";
            this.TAB_RESULTS_GRID.Location = new System.Drawing.Point(4, 23);
            this.TAB_RESULTS_GRID.Name = "TAB_RESULTS_GRID";
            this.TAB_RESULTS_GRID.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_RESULTS_GRID.Size = new System.Drawing.Size(484, 87);
            this.TAB_RESULTS_GRID.TabIndex = 0;
            this.TAB_RESULTS_GRID.Text = "Data Query Results";
            this.TAB_RESULTS_GRID.UseVisualStyleBackColor = true;
            // 
            // grdPreview
            // 
            this.grdPreview.AllowUserToAddRows = false;
            this.grdPreview.AllowUserToDeleteRows = false;
            this.grdPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPreview.Location = new System.Drawing.Point(3, 3);
            this.grdPreview.Name = "grdPreview";
            this.grdPreview.ReadOnly = true;
            this.grdPreview.Size = new System.Drawing.Size(478, 81);
            this.grdPreview.TabIndex = 1;
            // 
            // TAB_RESULTS_MAP
            // 
            this.TAB_RESULTS_MAP.Controls.Add(this.mapCtl);
            this.TAB_RESULTS_MAP.ImageKey = "map.png";
            this.TAB_RESULTS_MAP.Location = new System.Drawing.Point(4, 23);
            this.TAB_RESULTS_MAP.Name = "TAB_RESULTS_MAP";
            this.TAB_RESULTS_MAP.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_RESULTS_MAP.Size = new System.Drawing.Size(484, 87);
            this.TAB_RESULTS_MAP.TabIndex = 1;
            this.TAB_RESULTS_MAP.Text = "Map Preview";
            this.TAB_RESULTS_MAP.UseVisualStyleBackColor = true;
            // 
            // mapCtl
            // 
            this.mapCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapCtl.Location = new System.Drawing.Point(3, 3);
            this.mapCtl.Name = "mapCtl";
            this.mapCtl.Size = new System.Drawing.Size(478, 81);
            this.mapCtl.TabIndex = 0;
            // 
            // imgPreview
            // 
            this.imgPreview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPreview.ImageStream")));
            this.imgPreview.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPreview.Images.SetKeyName(0, "application_view_columns.png");
            this.imgPreview.Images.SetKeyName(1, "map.png");
            // 
            // bgStandard
            // 
            this.bgStandard.WorkerReportsProgress = true;
            this.bgStandard.WorkerSupportsCancellation = true;
            this.bgStandard.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgStandard_DoWork);
            this.bgStandard.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgStandard_RunWorkerCompleted);
            this.bgStandard.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgStandard_ProgressChanged);
            // 
            // bgSql
            // 
            this.bgSql.WorkerReportsProgress = true;
            this.bgSql.WorkerSupportsCancellation = true;
            this.bgSql.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgSql_DoWork);
            this.bgSql.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgSql_RunWorkerCompleted);
            this.bgSql.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgSql_ProgressChanged);
            // 
            // saveQueryDlg
            // 
            this.saveQueryDlg.Filter = "SDF Files (*.sdf)|*.sdf|SHP Files(*.shp)|*.shp";
            // 
            // SpatialDataPreviewCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SpatialDataPreviewCtl";
            this.Size = new System.Drawing.Size(494, 395);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ctxSave.ResumeLayout(false);
            this.grpQuery.ResumeLayout(false);
            this.tabQueryMode.ResumeLayout(false);
            this.pageStandard.ResumeLayout(false);
            this.pageStandard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdComputedFields)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.pageAggregates.ResumeLayout(false);
            this.pageAggregates.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpressions)).EndInit();
            this.pageSQL.ResumeLayout(false);
            this.pageSQL.PerformLayout();
            this.tabResults.ResumeLayout(false);
            this.TAB_RESULTS_GRID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPreview)).EndInit();
            this.TAB_RESULTS_MAP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpQuery;
        private System.Windows.Forms.TabControl tabQueryMode;
        private System.Windows.Forms.TabPage pageStandard;
        private System.Windows.Forms.TabPage pageAggregates;
        private System.Windows.Forms.TabPage pageSQL;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSchema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAggClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAggSchema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkDistinct;
        private System.Windows.Forms.DataGridView grdExpressions;
        private System.Windows.Forms.Button btnDeleteExpr;
        private System.Windows.Forms.Button btnAddExpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_EXPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_ALIAS;
        private System.Windows.Forms.Button btnEditFilter;
        private System.Windows.Forms.DataGridView grdComputedFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnClearComputedFields;
        private System.Windows.Forms.Button btnDeleteComputedField;
        private System.Windows.Forms.Button btnAddComputedField;
        private System.Windows.Forms.Button btnClearAggregates;
        private System.Windows.Forms.Button btnUncheckAllProperties;
        private System.Windows.Forms.Button btnCheckAllProperties;
        private System.Windows.Forms.CheckedListBox chkPropertyNames;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAggFilter;
        private System.Windows.Forms.TextBox txtAggFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabResults;
        private System.Windows.Forms.TabPage TAB_RESULTS_GRID;
        private System.Windows.Forms.DataGridView grdPreview;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.ComponentModel.BackgroundWorker bgStandard;
        private System.ComponentModel.BackgroundWorker bgSql;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCancel;
        private SplitButton splitSave;
        private System.Windows.Forms.ContextMenuStrip ctxSave;
        private System.Windows.Forms.ToolStripMenuItem saveToSDFToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveQueryDlg;
        private System.Windows.Forms.ImageList imgPreview;
        private System.Windows.Forms.TabPage TAB_RESULTS_MAP;
        private MapPreviewCtl mapCtl;
        private System.Windows.Forms.CheckBox chkMap;
    }
}
