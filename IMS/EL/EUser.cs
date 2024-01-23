using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EUser
    {
        private int _UserInfoID = -1;
        private string _UserName = string.Empty;
        private string _UserFullName = string.Empty;
        private string _Password = string.Empty;
        private int _UserID = 0;
        private DataTable _dtUser = null;
        private DataTable _dtOrg = null;

        public int UserInfoID
        {
            get { return _UserInfoID; }
            set { _UserInfoID = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string UserFullName
        {
            get { return _UserFullName; }
            set { _UserFullName = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public DataTable dtUser
        {
            get { return _dtUser; }
            set { _dtUser = value; }
        }
        public DataTable dtOrg
        {
            get { return _dtOrg; }
            set { _dtOrg = value; }
        }

        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string GSTIN { get; set; }
        public string Hno { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
    }
}
