using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EDistributor
    {
        private int _DistributorID = -1;
        private string _DistributorName = string.Empty;
        private string _ContactPerson = string.Empty;
        private string _EmailID = string.Empty;
        private string _GSTIN = string.Empty;
        private string _MobileNumber = string.Empty;
        private string _BranchName = string.Empty;
        private string _BAddress = string.Empty;
        private string _Remarks = string.Empty;
        private int _UserID = 0;
        private DataTable _dtDistributor = null;

        public int DistributorID
        {
            get{return _DistributorID;}
            set{_DistributorID = value;}
        }
        public string DistributorName
            {
                get { return _DistributorName; }
                set { _DistributorName = value; }
        }
        public string ContactPerson
            {
                get { return _ContactPerson; }
                set { _ContactPerson = value; }
        }
        public string EmailID
            {
                get { return _EmailID; }
                set { _EmailID = value; }
        }
        public string GSTIN
            {
                get { return _GSTIN; }
                set { _GSTIN = value; }
        }
        public string MobileNumber
            {
                get { return _MobileNumber; }
                set { _MobileNumber = value; }
        }
        public string BranchName
            {
                get { return _BranchName; }
                set { _BranchName = value; }
        }
        public string BAddress
            {
                get { return _BAddress; }
                set { _BAddress = value; }
        }
        public string Remarks
            {
                get { return _Remarks; }
                set { _Remarks = value; }
        }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public DataTable dtDistributor
        {
            get { return _dtDistributor; }
            set { _dtDistributor = value; }
        }
    }
}
