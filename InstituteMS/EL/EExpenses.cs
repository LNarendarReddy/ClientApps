using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EExpenses
    {
        private int _ExpensesID = -1;
        private string _ExpensesDEscription = string.Empty;
        private string _ExpenseName = string.Empty;
        private decimal _Amount = 0;
        private int _UserID = 0;
        private DataTable _dtExpenses = null;
        private DataTable _dtExpensesNAme = null;
        public int BranchID = -1;
        public int OrgID = -1;

        public int ExpensesID
        {
            get{return _ExpensesID;}
            set{_ExpensesID = value;}
        }
        public string ExpensesDEscription
            {
                get { return _ExpensesDEscription; }
                set { _ExpensesDEscription = value; }
        }
        public string ExpenseName
            {
                get { return _ExpenseName; }
                set { _ExpenseName = value; }
        }
        public decimal Amount
            {
                get { return _Amount; }
                set { _Amount = value; }
        }
        public int UserID
            {
                get { return _UserID; }
                set { _UserID = value; }
        }
        public DataTable dtExpenses
        {
            get { return _dtExpenses; }
            set { _dtExpenses = value; }
        }
        public DataTable dtExpensesNAme
        {
            get { return _dtExpensesNAme; }
            set { _dtExpensesNAme = value; }
        }
    }
}
