using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FdoToolbox.Base;
using ICSharpCode.Core;
using FdoToolbox.Base.Services;
using FdoToolbox.Core.ETL.Specialized;
using FdoToolbox.Core.Utility;
using FdoToolbox.Base.Controls;

namespace FdoToolbox.Express.Controls
{
    public partial class FileToFileCtl : UserControl, IViewContent
    {
        public FileToFileCtl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return ResourceService.GetString("TITLE_EXPRESS_BULK_COPY"); }
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

        public Control ContentControl
        {
            get { return this; }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string file = FileService.OpenFile(ResourceService.GetString("TITLE_OPEN_FILE"), ResourceService.GetString("FILTER_EXPRESS_BCP"));
            if (file != null)
                txtSource.Text = file;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string file = FileService.SaveFile(ResourceService.GetString("TITLE_SAVE_FILE"), ResourceService.GetString("FILTER_EXPRESS_BCP"));
            if (file != null)
                txtTarget.Text = file;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string source = txtSource.Text;
            string target = txtTarget.Text;

            if (FileService.FileExists(source) && !string.IsNullOrEmpty(target))
            {
                using (FdoBulkCopy bcp = ExpressUtility.CreateBulkCopy(source, target, chkCopySpatialContexts.Checked, true))
                {
                    EtlProcessCtl ctl = new EtlProcessCtl(bcp);
                    Workbench.Instance.ShowContent(ctl, ViewRegion.Dialog);
                    ViewContentClosing(this, EventArgs.Empty);
                }
            }
            else
            {
                MessageService.ShowError("Source and Target fields are required");
            }
        }

        private void btnBrowseDir_Click(object sender, EventArgs e)
        {
            string dir = FileService.GetDirectory(ResourceService.GetString("TITLE_CHOOSE_DIRECTORY"));
            if (dir != null)
                txtTarget.Text = dir;
        }
    }
}