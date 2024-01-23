using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DL;

namespace PMS
{
    public partial class frmDataBaseBackup : DevExpress.XtraEditors.XtraForm
    {
        DBranch objDBranch = new DBranch();
        public frmDataBaseBackup()
        {
            InitializeComponent();
        }
        private void frmDataBaseBackup_Load(object sender, EventArgs e)
        {
            try
            {
                 txtFilePath.EditValue = objDBranch.GetFilePath();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void txtFilePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                xtraFolderBrowserDialog1 = new XtraFolderBrowserDialog();
                if (xtraFolderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.EditValue = xtraFolderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnSaveFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                objDBranch.SaveFilePath(txtFilePath.EditValue);
                XtraMessageBox.Show("FilePath Saved successfully.\n\r" + txtFilePath.EditValue);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                object objfilePath = objDBranch.GenerateBackup();
                XtraMessageBox.Show("Database backup is done. Below is the path : \n\r" + objfilePath);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}