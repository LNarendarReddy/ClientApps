using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class DDoctorMaster
    {
        public EDoctor SaveDoctorMaster(EDoctor ObjEDoctor)
        {
            DataSet dsDoctor = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_Doctor]";
                    cmd.Parameters.AddWithValue("@DoctorID", ObjEDoctor.ID);
                    cmd.Parameters.AddWithValue("@DTitle", ObjEDoctor.Title);
                    cmd.Parameters.AddWithValue("@DName", ObjEDoctor.Name);
                    cmd.Parameters.AddWithValue("@Age", ObjEDoctor.Age);
                    cmd.Parameters.AddWithValue("@Qualification", ObjEDoctor.qualification);
                    cmd.Parameters.AddWithValue("@address", ObjEDoctor.Address);
                    cmd.Parameters.AddWithValue("@Email", ObjEDoctor.Email);
                    cmd.Parameters.AddWithValue("@phone", ObjEDoctor.Phone);
                    cmd.Parameters.AddWithValue("@AlternatePhone", ObjEDoctor.AlternatePhone);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEDoctor.UserID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEDoctor.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEDoctor.OrgID);
                    cmd.Parameters.AddWithValue("@NameHindi", ObjEDoctor.NAmeHindi);
                    cmd.Parameters.AddWithValue("@QualificationHindi", ObjEDoctor.QualificationHindi);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDoctor);
                    }
                    if (dsDoctor != null && dsDoctor.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsDoctor.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEDoctor.ID = IValue;
                            if (dsDoctor.Tables.Count > 1)
                                ObjEDoctor.dtDoctor = dsDoctor.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_UName"))
                    throw new Exception("Category Already Exists!!");
                else
                    throw new Exception("Error While Saving Category!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEDoctor;
        }

        public EDoctor GetDoctorMaster(EDoctor ObjEDoctor)
        {
            DataSet dsDoctorMaster = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_Doctor]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEDoctor.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDoctorMaster);
                    }
                    if (dsDoctorMaster != null && dsDoctorMaster.Tables.Count > 0)
                        ObjEDoctor.dtDoctor = dsDoctorMaster.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Category List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEDoctor;
        }

        public EDoctor SaveDoctorAvailability(EDoctor ObjEDoctor)
        {
            DataSet dsDoctorAvail = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Ins_DoctorAvailability]";
                    cmd.Parameters.AddWithValue("@DoctorAvailabilityID", ObjEDoctor.DoctorAvailabilityID);
                    cmd.Parameters.AddWithValue("@DoctorID", ObjEDoctor.DoctorID);
                    cmd.Parameters.AddWithValue("@FromDate", ObjEDoctor.FromDate);
                    cmd.Parameters.AddWithValue("@ToDate", null);                   
                    cmd.Parameters.AddWithValue("@UserID", ObjEDoctor.UserID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEDoctor.BranchID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEDoctor.OrgID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDoctorAvail);
                    }
                    if (dsDoctorAvail != null && dsDoctorAvail.Tables.Count > 0)
                    {
                        int IValue = 0;
                        string str = Convert.ToString(dsDoctorAvail.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IValue))
                        {
                            ObjEDoctor.DoctorAvailabilityID = IValue;
                            if (dsDoctorAvail.Tables.Count > 1)
                                ObjEDoctor.dtDoctorAvail = dsDoctorAvail.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_UName"))
                    throw new Exception("Category Already Exists!!");
                else
                    throw new Exception("Error While Saving Category!!");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEDoctor;
        }

        public EDoctor GetDoctorAvailability(EDoctor ObjEDoctor)
        {
            DataSet dsDoctorAvail = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[PMS_Get_DoctorAvailability]";
                    cmd.Parameters.AddWithValue("@DoctorID", ObjEDoctor.DoctorID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsDoctorAvail);
                    }
                    if (dsDoctorAvail != null && dsDoctorAvail.Tables.Count > 0)
                        ObjEDoctor.dtDoctorAvail = dsDoctorAvail.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Category List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEDoctor;
        }
    }
}
