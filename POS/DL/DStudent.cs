using EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DStudent
    {
        public EStudent SaveStudent(EStudent ObjEStudent)
        {
            DataSet dsStudent = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Ins_Student]";
                    cmd.Parameters.Add("@StudentID", ObjEStudent.StudentID);
                    cmd.Parameters.Add("@AdmissionNo", ObjEStudent.AdmissionNumber);
                    cmd.Parameters.Add("@FulName", ObjEStudent.FullName);
                    cmd.Parameters.Add("@Cnumber1", ObjEStudent.CNumber1);
                    cmd.Parameters.Add("@Cnumber2", ObjEStudent.CNumber2);
                    cmd.Parameters.Add("@Gender", ObjEStudent.Gender);
                    cmd.Parameters.Add("@RFID", ObjEStudent.RFID);
                    cmd.Parameters.Add("@UserID", ObjEStudent.UserID);
                    cmd.Parameters.Add("@Amount", ObjEStudent.Amount);
                    cmd.Parameters.Add("@Grade", ObjEStudent.Grade);
                    cmd.Parameters.Add("@Section", ObjEStudent.Section);
                    cmd.Parameters.Add("@FatherName", ObjEStudent.FatherName);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsStudent);
                    }
                    if (dsStudent != null && dsStudent.Tables.Count > 0)
                    {
                        int IVlaue = 0;
                        string str = Convert.ToString(dsStudent.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IVlaue))
                        {
                            ObjEStudent.StudentID = IVlaue;
                            if (dsStudent.Tables.Count > 2)
                            {
                                ObjEStudent.dtStudent = dsStudent.Tables[3];
                                if(dsStudent.Tables.Count > 3)
                                    ObjEStudent.dtPayment = dsStudent.Tables[2];
                            }
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_AdmissionNumber"))
                    throw new Exception("Student already Exists!!");
                else
                    throw new Exception("Error While Saving Student");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent GetStudent(EStudent ObjEStudent)
        {
            DataSet dsStudent = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Get_Student]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsStudent);
                    }
                    if (dsStudent != null && dsStudent.Tables.Count > 0)
                        ObjEStudent.dtStudent = dsStudent.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Student List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent SavePayment(EStudent ObjEStudent)
        {
            DataSet dsPayment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Ins_Transactions]";
                    cmd.Parameters.Add("@StudentID", ObjEStudent.StudentID);
                    cmd.Parameters.Add("@AdmissionNumber", ObjEStudent.AdmissionNumber);
                    cmd.Parameters.Add("@Amount", ObjEStudent.Amount);
                    cmd.Parameters.Add("@PaymentType", ObjEStudent.TType);
                    cmd.Parameters.Add("@UserId", ObjEStudent.UserID);
                    cmd.Parameters.Add("@RFIDNumber", ObjEStudent.RFID);
                    cmd.Parameters.Add("@Remarks", ObjEStudent.Remarks);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPayment);
                    }
                    if (dsPayment != null && dsPayment.Tables.Count > 0)
                    {
                        int IVlaue = 0;
                        string str = Convert.ToString(dsPayment.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IVlaue))
                        {
                            ObjEStudent.TransactionID = IVlaue;
                            if (dsPayment != null && dsPayment.Tables.Count > 1)
                            {
                                ObjEStudent.dtPayment = dsPayment.Tables[1];
                            }
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Payment");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent GetPayment(EStudent ObjEStudent)
        {
            DataSet dsPayment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Get_Transactions]";
                    cmd.Parameters.Add("@StudentID", ObjEStudent.StudentID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsPayment);
                    }
                    if (dsPayment != null && dsPayment.Tables.Count > 0)
                        ObjEStudent.dtPayment = dsPayment.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Payment List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent Saveimage(EStudent ObjEStudent)
        {
            DataSet dsPayment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Ins_ImageData]";
                    cmd.Parameters.Add("@StudentID", ObjEStudent.StudentID);
                    cmd.Parameters.Add("@ImageData", ObjEStudent.Imagedata);
                    cmd.Parameters.Add("@UserID", ObjEStudent.UserID);
                    Object obj = cmd.ExecuteScalar();
                    string str = Convert.ToString(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjEStudent;
        }

        public EStudent SaveOrgShortLogo(EStudent ObjEStudent)
        {
            DataSet dsPayment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Ins_orgshortlogo]";
                    cmd.Parameters.Add("@ImageData", ObjEStudent.Imagedata);
                    Object obj = cmd.ExecuteScalar();
                    string str = Convert.ToString(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjEStudent;
        }

        public EStudent SaveLongLogo(EStudent ObjEStudent)
        {
            DataSet dsPayment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Ins_orglonglogo]";
                    cmd.Parameters.Add("@ImageData", ObjEStudent.Imagedata);
                    Object obj = cmd.ExecuteScalar();
                    string str = Convert.ToString(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjEStudent;
        }

        public EStudent GetImage(EStudent ObjEStudent)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Get_ImageData]";
                    cmd.Parameters.Add("@StudentID", ObjEStudent.StudentID);
                    object obj = cmd.ExecuteScalar();
                    ObjEStudent.Imagedata = (byte[])obj;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Image");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent GetOrgShortLogo(EStudent ObjEStudent)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Get_OrgshortLogo]";
                    object obj = cmd.ExecuteScalar();
                    ObjEStudent.Imagedata = (byte[])obj;
                }
            }
            catch (Exception ex) { }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent GetOrgLongLogo(EStudent ObjEStudent)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Get_OrgLONGLogo]";
                    object obj = cmd.ExecuteScalar();
                    ObjEStudent.Imagedata = (byte[])obj;
                }
            }
            catch (Exception ex) { }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent GETStudentByRFID(EStudent ObjEStudent)
        {
            DataSet dsStudent = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Get_StudentByRFID]";
                    cmd.Parameters.Add("@RFID", ObjEStudent.RFID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsStudent);
                    }
                    if (dsStudent != null && dsStudent.Tables.Count > 0)
                    {
                        ObjEStudent.dtStudent = dsStudent.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Student Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent GetTReport(EStudent ObjEStudent)
        {
            DataSet dsStudent = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[POS_Rpt_Transactions]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsStudent);
                    }
                    if (dsStudent != null && dsStudent.Tables.Count > 0)
                    {
                        ObjEStudent.dtReport = dsStudent.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Report");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }
    }
}
