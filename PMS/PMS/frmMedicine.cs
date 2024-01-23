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
using System.Resources;
using System.Reflection;
using EL;
using DL;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS
{
    public partial class frmMedicine : DevExpress.XtraEditors.XtraForm
    {
        EMedicine ObjEMedicine = new EMedicine();
        DMedicine ObjDMedicine = new DMedicine();
        public string stPosologyCheck = string.Empty;
        int MedicineID;
        public frmMedicine(int nMedicineID)
        {
            InitializeComponent();
            MedicineID = nMedicineID;
            MedicineDetails(MedicineID);
        }

        private void frmMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMedicinePower();
                LoadMedicineType();
                LoadMedicineMessure();
                LoadMedicinedetails();
                LoadQuantity();
                LoadHowToApply();
                LoadHowmanyTimes();
                LoadWhen();
                LoadWith();
                LoadTimeInterval();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void LoadMedicineType()
        {
            try
            {
                ObjDMedicine.GetMedicineType(ObjEMedicine);
                cmbType.Properties.DataSource = ObjEMedicine.dtMedicineType;
                cmbType.Properties.DisplayMember = "TypeName";
                cmbType.Properties.ValueMember = "MedicineTypeID";
            }
            catch (Exception ex) { throw ex; }
        }
        private void LoadMedicinePower()
        {
            try
            {
                ObjDMedicine.GetMedicinePower(ObjEMedicine);
                cmbPower.Properties.DataSource = ObjEMedicine.dtMedicinePower;
                cmbPower.Properties.DisplayMember = "PowerName";
                cmbPower.Properties.ValueMember = "MedicinePowerID";
            }
            catch (Exception ex) { throw ex; }
        }
        private void LoadMedicineMessure()
        {
            try
            {
                ObjDMedicine.GetMedicineMessure(ObjEMedicine);
                cmbMessure.Properties.DataSource = ObjEMedicine.dtMedicineMeasure;
                cmbMessure.Properties.DisplayMember = "MessureType";
                cmbMessure.Properties.ValueMember = "MedicineMessureID";
            }
            catch (Exception ex) { throw ex; }
        }
        private void cmbQtyMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbQtyMeasure.Text == "Apply" || cmbQtyMeasure.Text == "Apply Hardly")
                {
                    GrpHowToApply.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                else
                {
                    GrpHowToApply.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void chkIsLoose_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjEMedicine.MedicineID <= 0)
                    ObjEMedicine.MedicineID = -1;

                ObjEMedicine.MedicineCode = txtMedicineCode.Text.Trim();
                ObjEMedicine.MedinceName = txtMedName.Text.Trim();
                ObjEMedicine.GenericName = txtGenericName.Text.Trim();
                ObjEMedicine.MedicineTypeID = Convert.ToInt32(cmbType.EditValue);
                ObjEMedicine.MedicinePowerID = Convert.ToInt32(cmbPower.EditValue);
                ObjEMedicine.MedicineQuantity = 1;
                ObjEMedicine.MedicineMessureID = Convert.ToInt32(cmbMessure.EditValue);
                ObjEMedicine.SPrice = Convert.ToDouble(txtPrice.EditValue);
                ObjEMedicine.SoldInLoose = false;
                ObjEMedicine.PackQuantity = 1;
                ObjEMedicine.PackQuantityMessureID = 1;
                ObjEMedicine.ReorderLevel = Convert.ToInt32(txtReOrderLevel.Text.Trim());
                ObjEMedicine.CurrentStock = txtPackStock.Text.Trim() == "" ? 0 : Convert.ToInt32(txtPackStock.Text.Trim());
                ObjEMedicine.MedicinePosologyQuantity = Convert.ToInt32(txtposoQty.Text.Trim());
                ObjEMedicine.MedinceQuantityMessure = Convert.ToInt32(cmbQtyMeasure.EditValue);
                ObjEMedicine.HowtoApply = Convert.ToInt32(cmbHowToApply.EditValue);
                ObjEMedicine.HowManyTimeMessure = Convert.ToInt32(cmbHMTMeasure.EditValue);
                ObjEMedicine.HowmanyTimesValue = Convert.ToInt32(txtHMTNo.EditValue);
                ObjEMedicine.MedinceWhen = Convert.ToInt32(cmbWhen.EditValue);
                ObjEMedicine.TimeIntervel = Convert.ToInt32(txtTimeIntervalNo.EditValue);
                ObjEMedicine.TimeIntervelMessure = Convert.ToInt32(cmbTimeIntervaMeasure.EditValue);
                ObjEMedicine.MedicineWith = Convert.ToInt32(cmbwith.EditValue);
                ObjEMedicine.DayIntervel = Convert.ToInt32(txtDayInterval.EditValue);
                ObjEMedicine.EmergencySOS = Convert.ToBoolean(chkSOS.CheckState);
                ObjEMedicine.EmergencyNow = Convert.ToBoolean(chkNow.CheckState);
                ObjEMedicine.KeepinFridge = Convert.ToBoolean(chkFridge.CheckState);
                ObjEMedicine.InEye = Convert.ToBoolean(chkEye.CheckState);
                ObjEMedicine.InEar = Convert.ToBoolean(chkEar.CheckState);
                ObjEMedicine.InNose = Convert.ToBoolean(chkNose.CheckState);
                ObjEMedicine.InHairRoots = Convert.ToBoolean(chkHair.CheckState);
                ObjEMedicine.InMouthUlcers = Convert.ToBoolean(chkMouth.CheckState);
                ObjEMedicine.ForGargil = Convert.ToBoolean(chkGargil.CheckState);
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjEMedicine.OrgID = Utility.OrgID;
                ObjEMedicine.UserID = Utility.UserID;
                ObjEMedicine.PosologyCheck = txtCheck.Text.Trim();
                ObjDMedicine.SaveMedicine(ObjEMedicine);
                gdMedicine.DataSource = ObjEMedicine.dtMedicineList;
                clearFields();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void LoadMedicinedetails()
        {
            try
            {
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjDMedicine.GetMedicineList(ObjEMedicine);
                gdMedicine.DataSource = ObjEMedicine.dtMedicineList;
            }
            catch (Exception ex) { throw ex; }
        }
        private void clearFields()
        {
            txtMedicineCode.Text = string.Empty;
            txtMedName.Text = string.Empty;
            txtGenericName.Text = string.Empty;
            cmbType.EditValue = -1;
            cmbPower.EditValue = -1;
            cmbMessure.EditValue = -1;
            txtPrice.Text = string.Empty;
            txtReOrderLevel.Text = string.Empty;
            txtPackStock.Text = "0";
            txtposoQty.EditValue = 0;
            cmbQtyMeasure.EditValue = -1;
            cmbHowToApply.EditValue = -1;
            cmbHMTMeasure.EditValue = -1;
            cmbWhen.EditValue = -1;
            txtTimeIntervalNo.EditValue = 0;
            txtHMTNo.EditValue = 0;
            cmbTimeIntervaMeasure.EditValue = -1;
            cmbwith.EditValue = 0;
            txtDayInterval.EditValue = 0;
            chkSOS.Checked = false;
            chkNow.Checked = false;
            chkFridge.Checked = false;
            chkEye.Checked = false;
            chkEar.Checked = false;
            chkNose.Checked = false;
            chkHair.Checked = false;
            chkMouth.Checked = false;
            chkGargil.Checked = false;
            txtCheck.Text = string.Empty;
        }
        private void LoadQuantity()
        {
            DataTable dtQuantity = new DataTable();
            dtQuantity.Columns.Add("ID", typeof(int));
            dtQuantity.Columns.Add("Value", typeof(string));
            DataRow dr = dtQuantity.NewRow();
            dr["ID"] = 1;
            dr["Value"] = "Tab";
            dtQuantity.Rows.Add(dr);
            DataRow dr1 = dtQuantity.NewRow();
            dr1["ID"] = 2;
            dr1["Value"] = "Drops";
            dtQuantity.Rows.Add(dr1);
            DataRow dr2 = dtQuantity.NewRow();
            dr2["ID"] = 3;
            dr2["Value"] = "TSF";
            dtQuantity.Rows.Add(dr2);
            DataRow dr3 = dtQuantity.NewRow();
            dr3["ID"] = 4;
            dr3["Value"] = "Khurag";
            dtQuantity.Rows.Add(dr3);
            DataRow dr4 = dtQuantity.NewRow();
            dr4["ID"] = 5;
            dr4["Value"] = "Apply";
            dtQuantity.Rows.Add(dr4);
            DataRow dr5 = dtQuantity.NewRow();
            dr5["ID"] = 6;
            dr5["Value"] = "Apply Hardly";
            dtQuantity.Rows.Add(dr5);
            cmbQtyMeasure.Properties.DataSource = dtQuantity;
            cmbQtyMeasure.Properties.DisplayMember = "Value";
            cmbQtyMeasure.Properties.ValueMember = "ID";
        }
        private void LoadHowToApply()
        {
            DataTable dtApply = new DataTable();
            dtApply.Columns.Add("ID", typeof(int));
            dtApply.Columns.Add("Value", typeof(string));
            DataRow dr = dtApply.NewRow();
            dr["ID"] = 1;
            dr["Value"] = "Mix";
            dtApply.Rows.Add(dr);
            DataRow dr1 = dtApply.NewRow();
            dr1["ID"] = 2;
            dr1["Value"] = "Seperately";
            dtApply.Rows.Add(dr1);
            cmbHowToApply.Properties.DataSource = dtApply;
            cmbHowToApply.Properties.DisplayMember = "Value";
            cmbHowToApply.Properties.ValueMember = "ID";
        }
        private void LoadHowmanyTimes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Value", typeof(string));
            DataRow dr = dt.NewRow();
            dr["ID"] = 1;
            dr["Value"] = "OD";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["ID"] = 2;
            dr1["Value"] = "BD";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["ID"] = 3;
            dr2["Value"] = "TDS";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["ID"] = 4;
            dr3["Value"] = "MNEN";
            dt.Rows.Add(dr3);
            DataRow dr4 = dt.NewRow();
            dr4["ID"] = 5;
            dr4["Value"] = "Hourly";
            dt.Rows.Add(dr4);
            DataRow dr5 = dt.NewRow();
            dr5["ID"] = 6;
            dr5["Value"] = "Minutes";
            dt.Rows.Add(dr5);
            cmbHMTMeasure.Properties.DataSource = dt;
            cmbHMTMeasure.Properties.DisplayMember = "Value";
            cmbHMTMeasure.Properties.ValueMember = "ID";
        }
        private void LoadWhen()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Value", typeof(string));
            DataRow dr = dt.NewRow();
            dr["ID"] = 1;
            dr["Value"] = "BT";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["ID"] = 2;
            dr1["Value"] = "ES";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["ID"] = 3;
            dr2["Value"] = "BM";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["ID"] = 4;
            dr3["Value"] = "AM";
            dt.Rows.Add(dr3);
            DataRow dr4 = dt.NewRow();
            dr4["ID"] = 5;
            dr4["Value"] = "None";
            dt.Rows.Add(dr4);
            cmbWhen.Properties.DataSource = dt;
            cmbWhen.Properties.DisplayMember = "Value";
            cmbWhen.Properties.ValueMember = "ID";
        }
        private void LoadTimeInterval()
        {
            DataTable dtApply = new DataTable();
            dtApply.Columns.Add("ID", typeof(int));
            dtApply.Columns.Add("Value", typeof(string));
            DataRow dr = dtApply.NewRow();
            dr["ID"] = 1;
            dr["Value"] = "Hours";
            dtApply.Rows.Add(dr);
            DataRow dr1 = dtApply.NewRow();
            dr1["ID"] = 2;
            dr1["Value"] = "Minutes";
            dtApply.Rows.Add(dr1);
            cmbTimeIntervaMeasure.Properties.DataSource = dtApply;
            cmbTimeIntervaMeasure.Properties.DisplayMember = "Value";
            cmbTimeIntervaMeasure.Properties.ValueMember = "ID";
        }
        private void LoadWith()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Value", typeof(string));
            DataRow dr = dt.NewRow();
            dr["ID"] = 1;
            dr["Value"] = "None";
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["ID"] = 2;
            dr1["Value"] = "Water";
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["ID"] = 3;
            dr2["Value"] = "HW";
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["ID"] = 4;
            dr3["Value"] = "Milk";
            dt.Rows.Add(dr3);
            DataRow dr4 = dt.NewRow();
            dr4["ID"] = 5;
            dr4["Value"] = "Glycerine";
            dt.Rows.Add(dr4);
            DataRow dr5 = dt.NewRow();
            dr5["ID"] = 6;
            dr5["Value"] = "Honey";
            dt.Rows.Add(dr5);
            DataRow dr6 = dt.NewRow();
            dr6["ID"] = 7;
            dr6["Value"] = "Brush";
            dt.Rows.Add(dr6);
            cmbwith.Properties.DataSource = dt;
            cmbwith.Properties.DisplayMember = "Value";
            cmbwith.Properties.ValueMember = "ID";
        }

        private void cmbQtyMeasure_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbQtyMeasure.Text == "Apply" || cmbQtyMeasure.Text == "Apply Hardly")
                {
                    GrpHowToApply.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                else
                {
                    GrpHowToApply.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }
        private void gvMedicine_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int nMedicineID = Convert.ToInt32(gvMedicine.GetFocusedRowCellValue("MedicineID"));
                MedicineDetails(nMedicineID);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void MedicineDetails(int nMedicineID)
        {
            try
            {
                ObjEMedicine.MedicineID = nMedicineID;
                ObjDMedicine.GetMedicinedetails(ObjEMedicine);
                if (ObjEMedicine.dsMedicineDetails != null && ObjEMedicine.dsMedicineDetails.Tables.Count > 0 && ObjEMedicine.dsMedicineDetails.Tables[0].Rows.Count > 0)
                {
                    txtMedicineCode.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["MedicineCode"];
                    txtMedName.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["MedicineName"];
                    txtGenericName.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["GenericName"];
                    cmbType.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["MedicineTypeID"];
                    cmbPower.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["MedicinePowerID"];
                    cmbMessure.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["MedicinceMessureID"];
                    txtPrice.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["SPrice"];
                    txtReOrderLevel.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["ReOrderLevel"];
                    if (ObjEMedicine.dsMedicineDetails.Tables.Count > 1 && ObjEMedicine.dsMedicineDetails.Tables[1].Rows.Count > 0)
                    {
                        txtposoQty.EditValue = ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["MedicineQuantity"];
                        cmbQtyMeasure.EditValue = Convert.ToInt32(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["MedinceQuantityMessure"]);
                        cmbHowToApply.EditValue = Convert.ToInt32(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["HowtoApply"]);
                        cmbHMTMeasure.EditValue = Convert.ToInt32(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["HowManyTimeMessure"]);
                        txtHMTNo.EditValue = ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["HowmanyTimesValue"];
                        cmbWhen.EditValue = Convert.ToInt32(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["MedinceWhen"]);
                        txtTimeIntervalNo.EditValue = ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["TimeIntervel"];
                        cmbTimeIntervaMeasure.EditValue = Convert.ToInt32(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["TimeIntervelMessure"]);
                        cmbwith.EditValue = Convert.ToInt32(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["MedicineWith"]);
                        txtDayInterval.EditValue = ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["DayIntervel"].ToString();
                        chkSOS.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["EmergencySOS"]);
                        chkNow.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["EmergencyNow"]);
                        chkFridge.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["KeepinFridge"]);
                        chkEye.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["InEye"]);
                        chkEar.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["InEar"]);
                        chkNose.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["InNose"]);
                        chkHair.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["InHairRoots"]);
                        chkMouth.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["InMouthUlcers"]);
                        chkGargil.Checked = Convert.ToBoolean(ObjEMedicine.dsMedicineDetails.Tables[1].Rows[0]["ForGargil"]);
                        txtCheck.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["PosologyString"];
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void cmbHMTMeasure_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbHMTMeasure.Text == "MNEN")
                    cmbWhen.EditValue = 5;
                else
                {
                    if (cmbHMTMeasure.Text == "Hourly" || cmbHMTMeasure.Text == "Minutes")
                        HMTLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    else
                        HMTLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string stTimeInterval = null;
                if (cmbTimeIntervaMeasure.Text == "Hours")
                    stTimeInterval = Convert.ToInt32(txtTimeIntervalNo.Text) > 0 ? Utility.GetResource("Every") + " " + txtTimeIntervalNo.Text + " " + Utility.GetResource("Hours") + " " : null;
                else
                    stTimeInterval = Convert.ToInt32(txtTimeIntervalNo.Text) > 0 ? Utility.GetResource("Every") + " " + txtTimeIntervalNo.Text + " " + Utility.GetResource("Minute") + " " : null;
                string stDayInterval = Convert.ToInt32(txtDayInterval.Text) > 0 ? txtDayInterval.Text + " " + Utility.GetResource("DAYINTERVAL") + " " : null;
                string stSoS = null, stNow = null, stFridge = null, stEye = null, stEar = null, stNose = null, stMouth = null, stHair = null, stGargil = null;
                if (chkSOS.Checked == true)
                    stSoS = Utility.GetResource("SoS") + " ";
                if (chkNow.Checked == true)
                    stNow = Utility.GetResource("Now") + " ";
                if (chkFridge.Checked == true)
                    stFridge = Utility.GetResource("FRIDGE") + " ";
                if (chkEye.Checked == true)
                    stEye = Utility.GetResource("EYE") + " ";
                if (chkEar.Checked == true)
                    stEar = Utility.GetResource("EAR") + " ";
                if (chkNose.Checked == true)
                    stNose = Utility.GetResource("NOSE") + " ";
                if (chkMouth.Checked == true)
                    stMouth = Utility.GetResource("MOUTH") + " ";
                if (chkHair.Checked == true)
                    stHair = Utility.GetResource("HAIR") + " ";
                if (chkGargil.Checked == true)
                    stGargil = Utility.GetResource("GARGIL");
                string stQtyMeasure = null;
                if (cmbQtyMeasure.Text == "Apply" && cmbHowToApply.Text == "Mix")
                    stQtyMeasure = Utility.GetResource("MIX") + " ";
                else if (cmbQtyMeasure.Text == "Apply" && cmbHowToApply.Text == "Seperately")
                    stQtyMeasure = Utility.GetResource("SEPERATE") + " ";
                else if (cmbQtyMeasure.Text == "Apply Hardly" && cmbHowToApply.Text == "Mix")
                    stQtyMeasure = Utility.GetResource("HARDMIX") + " ";
                else if (cmbQtyMeasure.Text == "Apply Hardly" && cmbHowToApply.Text == "Seperately")
                    stQtyMeasure = Utility.GetResource("HARDSEPERATE") + " ";
                else
                    stQtyMeasure = cmbQtyMeasure.Text != string.Empty ? Utility.GetResource(cmbQtyMeasure.Text) + " " : null;
                string stHMT = null;
                if (cmbHMTMeasure.Text == "Hourly")
                    stHMT = txtHMTNo.Text + " " + Utility.GetResource("Hourly");
                else if (cmbHMTMeasure.Text == "Minutes")
                    stHMT = txtHMTNo.Text + " " + Utility.GetResource("MINUTES");
                else
                    stHMT = cmbHMTMeasure.Text != string.Empty ? Utility.GetResource(cmbHMTMeasure.Text) + " " : null;
                string stPosoQty = Convert.ToInt32(txtposoQty.Text) > 0 ? txtposoQty.Text + " " : null;
                string stWhen = cmbWhen.Text != string.Empty ? Utility.GetResource(cmbWhen.Text) + " " : null;
                string stWith = cmbwith.Text != string.Empty ? Utility.GetResource(cmbwith.Text) + " " : null;

                txtCheck.Text = stPosoQty + stQtyMeasure + stHMT + stWhen + stTimeInterval + stWith + stDayInterval + stSoS + stNow + stEye + stEar + stNose + stMouth + stHair + stGargil + stFridge;
                stPosologyCheck = txtCheck.Text;
            }
            catch (Exception ex) { Utility.ShowError(ex); }

        }

        private void btnNewMedicine_Click(object sender, EventArgs e)
        {
            ObjEMedicine.MedicineID = -1;
            clearFields();
        }
    }
}