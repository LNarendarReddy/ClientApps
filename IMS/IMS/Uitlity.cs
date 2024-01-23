using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public static class Utility
    {
        public static int UserID = 0;
        public static string UserName = string.Empty;
        public static string UserFullName = string.Empty;
        public static string Password = string.Empty;

        public static int OrganizationID = 0;
        public static string Name = string.Empty;
        public static string ContactNumber = string.Empty;
        public static string GSTIN = string.Empty;
        public static string Hno = string.Empty;
        public static string Street = string.Empty;
        public static string City = string.Empty;
        public static string District = string.Empty;
        public static string State = string.Empty;
        public static string Country = string.Empty;
        public static string PinCode = string.Empty;

        public static void ShowError(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ValidateRequiredFields(List<Control> requiredFields)
        {

            bool IsValid = true;
            Control ctrlToFocus = null;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Please enter the following Values");



            sb.AppendLine();
            foreach (Control ctrl in requiredFields)
            {
                if (ctrl is TextEdit && ctrl.Text.Trim() == string.Empty)
                {
                    IsValid = false;
                    sb.AppendLine(" * " + ctrl.Tag);
                    if (ctrlToFocus == null)
                        ctrlToFocus = ctrl;
                }
                else if (ctrl is DevExpress.XtraEditors.LookUpEdit && ((DevExpress.XtraEditors.LookUpEdit)ctrl).EditValue == null)
                {
                    IsValid = false;
                    sb.AppendLine(" * " + ctrl.Tag);
                    if (ctrlToFocus == null)
                        ctrlToFocus = ctrl;
                }
                else if (ctrl is DevExpress.XtraEditors.LookUpEdit && ((DevExpress.XtraEditors.LookUpEdit)ctrl).Text.ToString() == "[Select]")
                {
                    IsValid = false;
                    sb.AppendLine(" * " + ctrl.Tag);
                    if (ctrlToFocus == null)
                        ctrlToFocus = ctrl;
                }
                else if (ctrl is DevExpress.XtraEditors.LookUpEdit && ((DevExpress.XtraEditors.LookUpEdit)ctrl).Text.ToString() == string.Empty)
                {
                    IsValid = false;
                    sb.AppendLine(" * " + ctrl.Tag);
                    if (ctrlToFocus == null)
                        ctrlToFocus = ctrl;
                }
            }
            if (!IsValid)
            {
                XtraMessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ctrlToFocus.Focus();
            }
            return IsValid;
        }

        public static void Setfocus(GridView view, string ColumnName, int Value)
        {
            try
            {
                if (Value > -1)
                {
                    int rowHandle = view.LocateByValue(ColumnName, Value);
                    if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        view.FocusedRowHandle = rowHandle;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
