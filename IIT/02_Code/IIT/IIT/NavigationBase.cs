using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace IIT
{
    public class NavigationBase : XtraUserControl
    {
        IEnumerable<ActionText> helpText;

        string caption = string.Empty;

        protected string RequestedType { get; set; }

        protected BaseEdit RequestingControl { get; set; }

        public virtual NavigationBase PreviousControl { get; set; }

        public virtual IEnumerable<ActionText> HelpText => helpText;

        public virtual string Caption => string.IsNullOrEmpty(caption) ? Name : caption;

        public string Header => PreviousControl != null ? PreviousControl.Header + " > " + Caption : Caption;

        public virtual bool HandlesESC => false;

        public virtual bool ShowQuickOptions => true;

        public NavigationBase(string _caption = "")
        { 
            helpText = new List<ActionText>();
            caption = _caption;
        }
        private NavigationBase()
        {

        }
        protected void AddRequestForCreate(string requestedType, BaseEdit requestingControl)
        {
            RequestedType = requestedType;
            RequestingControl = requestingControl;
            frmSingularMain.Instance.AddRequest(requestedType);
        }

        protected void FillFromCreateRequest()
        {
            if (string.IsNullOrEmpty(RequestedType)) return;

            if (frmSingularMain.Instance.HasRequest(RequestedType))
            {
                RequestingControl.EditValue = frmSingularMain.Instance.GetRequestValue(RequestedType);
                frmSingularMain.Instance.RemoveRequest(RequestedType);
                RequestingControl.Focus();
            }

            RequestedType = string.Empty;
            RequestingControl = null;
        }

        public void textEdit1_Validating(object sender, CancelEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (!Regex.IsMatch(textEdit.EditValue.ToString(), @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}", RegexOptions.IgnoreCase))
                e.Cancel = true;
        }
    }
}
