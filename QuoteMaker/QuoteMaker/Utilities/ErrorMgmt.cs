using DevExpress.XtraEditors;
using log4net;
using System;
using System.Windows.Forms;

namespace QuoteMaker
{
    public static class ErrorMgmt
    {
        public static readonly ILog Errorlog = log4net.LogManager.GetLogger("Errorlog");
        public static void ShowError(Exception ex)
        {
            try
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { throw ex; }
        }
        public static void ShowErrorMessage(string ex)
        {
            try
            {
                XtraMessageBox.Show(ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { throw; }
        }
    }
}
