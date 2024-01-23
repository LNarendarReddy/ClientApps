using DevExpress.Utils.Gesture;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuoteMaker.Models
{
    public class Item : EntityBase
    {
        public object ItemCodeID { get; set; }

        public object ItemID { get; set; }

        public object ItemCode { get; set; }

        public object ItemName { get; set; }

        public object SKUCode { get; set; }

        public object HSNCode { get; set; }

        public object SalePrice { get; set; }

        public object MRP { get; set; }

        public object GSTID { get; set; }

        public object CategoryID { get; set; }

        public object CategoryName { get; set; }

        public object SubCategoryID { get; set; }

        public object SubCategoryName { get; set; }

        public object IsNewToggleSwitched { get; set; }

        public object IsEAN { get; set; }

        public Dictionary<string, object> Params
        {
            get => Parameters();
        }
        protected override Dictionary<string, object> Parameters()
        {
            return new Dictionary<string, object>
            {
                { "ItemCodeID", ItemCodeID},
                { "ItemID",  ItemID},
                { "ItemCode", ItemCode},
                { "ItemName",  ItemName},
                { "SKUCode", SKUCode},
                { "HSNCode",  HSNCode},
                { "SalePrice",  SalePrice},
                { "MRP", MRP},
                { "GSTID",  GSTID},
                { "CategoryID",  CategoryID},
                { "SubCategoryID",  SubCategoryID},
                { "USERID", UserID},
                { "ISEAN", IsEAN}
            };
        }
    }
    public class ItemNewCode : EntityBase
    {

        public object Code { get; set; }

        public bool isSKUorItem { get; set; }
        public Dictionary<string, object> Params
        {
            get => Parameters();
        }
        protected override Dictionary<string, object> Parameters()
        {
            return new Dictionary<string, object>
            {
                { "Code", Code},
                { "isSKUorItem",  isSKUorItem}
            };
        }
    }
}
