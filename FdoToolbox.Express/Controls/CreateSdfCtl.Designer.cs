namespace FdoToolbox.Express.Controls
{
    partial class CreateSdfCtl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSdfFile = new System.Windows.Forms.TextBox();
            this.txtFeatureSchema = new System.Windows.Forms.TextBox();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.chkConnect = new System.Windows.Forms.CheckBox();
            this.btnSdf = new System.Windows.Forms.Button();
            this.btnSchema = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkAlterSchema = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SDF File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Feature Schema Definition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection Name";
            // 
            // txtSdfFile
            // 
            this.txtSdfFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSdfFile.Location = new System.Drawing.Point(150, 13);
            this.txtSdfFile.Name = "txtSdfFile";
            this.txtSdfFile.ReadOnly = true;
            this.txtSdfFile.Size = new System.Drawing.Size(396, 20);
            this.txtSdfFile.TabIndex = 3;
            // 
            // txtFeatureSchema
            // 
            this.txtFeatureSchema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeatureSchema.Location = new System.Drawing.Point(150, 40);
            this.txtFeatureSchema.Name = "txtFeatureSchema";
            this.txtFeatureSchema.ReadOnly = true;
            this.txtFeatureSchema.Size = new System.Drawing.Size(396, 20);
            this.txtFeatureSchema.TabIndex = 4;
            // 
            // txtConnectionName
            // 
            this.txtConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionName.Location = new System.Drawing.Point(150, 104);
            this.txtConnectionName.Name = "txtConnectionName";
            this.txtConnectionName.Size = new System.Drawing.Size(396, 20);
            this.txtConnectionName.TabIndex = 5;
            // 
            // chkConnect
            // 
            this.chkConnect.AutoSize = true;
            this.chkConnect.Location = new System.Drawing.Point(150, 81);
            this.chkConnect.Name = "chkConnect";
            this.chkConnect.Size = new System.Drawing.Size(244, 17);
            this.chkConnect.TabIndex = 6;
            this.chkConnect.Text = "Once the SDF is created, create a connection";
            this.chkConnect.UseVisualStyleBackColor = true;
            this.chkConnect.CheckedChanged += new System.EventHandler(this.chkConnect_CheckedChanged);
            // 
            // btnSdf
            // 
            this.btnSdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSdf.Location = new System.Drawing.Point(552, 11);
            this.btnSdf.Name = "btnSdf";
            this.btnSdf.Size = new System.Drawing.Size(30, 23);
            this.btnSdf.TabIndex = 7;
            this.btnSdf.Text = "...";
            this.btnSdf.UseVisualStyleBackColor = true;
            this.btnSdf.Click += new System.EventHandler(this.btnSdf_Click);
            // 
            // btnSchema
            // 
            this.btnSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchema.Location = new System.Drawing.Point(552, 38);
            this.btnSchema.Name = "btnSchema";
            this.btnSchema.Size = new System.Drawing.Size(30, 23);
            this.btnSchema.TabIndex = 8;
            this.btnSchema.Text = "...";
            this.btnSchema.UseVisualStyleBackColor = true;
            this.btnSchema.Click += new System.EventHandler(this.btnSchema_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(426, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(507, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkAlterSchema
            // 
            this.chkAlterSchema.AutoSize = true;
            this.chkAlterSchema.Location = new System.Drawing.Point(400, 81);
            this.chkAlterSchema.Name = "chkAlterSchema";
            this.chkAlterSchema.Size = new System.Drawing.Size(155, 17);
            this.chkAlterSchema.TabIndex = 11;
            this.chkAlterSchema.Text = "Fix schema incompatibilities";
            this.chkAlterSchema.UseVisualStyleBackColor = true;
            // 
            // CreateSdfCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAlterSchema);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSchema);
            this.Controls.Add(this.btnSdf);
            this.Controls.Add(this.chkConnect);
            this.Controls.Add(this.txtConnectionName);
            this.Controls.Add(this.txtFeatureSchema);
            this.Controls.Add(this.txtSdfFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateSdfCtl";
            this.Size = new System.Drawing.Size(591, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSdfFile;
        private System.Windows.Forms.TextBox txtFeatureSchema;
        private System.Windows.Forms.TextBox txtConnectionName;
        private System.Windows.Forms.CheckBox chkConnect;
        private System.Windows.Forms.Button btnSdf;
        private System.Windows.Forms.Button btnSchema;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAlterSchema;
    }
}
