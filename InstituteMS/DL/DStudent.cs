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
                    cmd.CommandText = "[P_Ins_Student]";
                    cmd.Parameters.AddWithValue("@StudentID", ObjEStudent.StudentID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEStudent.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEStudent.BranchID);
                    cmd.Parameters.AddWithValue("@FullName", ObjEStudent.FullName);
                    cmd.Parameters.AddWithValue("@CNumber", ObjEStudent.CNumber);
                    cmd.Parameters.AddWithValue("@Gender", ObjEStudent.Gender);
                    cmd.Parameters.AddWithValue("@EmailID", ObjEStudent.EmailID);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEStudent.UserID);
                    cmd.Parameters.AddWithValue("@AYear", ObjEStudent.AYear);
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
                            if (dsStudent != null && dsStudent.Tables.Count > 1)
                                ObjEStudent.dtStudent = dsStudent.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains(""))
                    throw new Exception("Student already Exists!!", ex);
                else
                    throw new Exception("Error While Saving Student", ex);
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
                    cmd.CommandText = "[P_Get_Student]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEStudent.BranchID);
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
                throw new Exception("Error While Retrieving Student List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent SaveCourse(EStudent ObjEStudent)
        {
            DataSet dsCourse = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_StudentCourseMap]";
                    cmd.Parameters.AddWithValue("@StudentID", ObjEStudent.StudentID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjEStudent.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEStudent.BranchID);
                    cmd.Parameters.AddWithValue("@FullName", ObjEStudent.FullName);
                    cmd.Parameters.AddWithValue("@CNumber", ObjEStudent.CNumber);
                    cmd.Parameters.AddWithValue("@Gender", "");
                    cmd.Parameters.AddWithValue("@EmailID", ObjEStudent.EmailID);
                    cmd.Parameters.AddWithValue("@StudentCourseMapID", ObjEStudent.StudentCourseMapID);
                    cmd.Parameters.AddWithValue("@CourseID", ObjEStudent.CourseID);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEStudent.UserID);
                    cmd.Parameters.AddWithValue("@DueDate", ObjEStudent.DueDate);
                    cmd.Parameters.AddWithValue("@Fees", ObjEStudent.Fees);
                    cmd.Parameters.AddWithValue("@IDIssued", ObjEStudent.IDIssued);
                    cmd.Parameters.AddWithValue("@MAIssued", ObjEStudent.MAIssued);
                    cmd.Parameters.AddWithValue("@Payment", ObjEStudent.Advance);
                    cmd.Parameters.AddWithValue("@BNumber", ObjEStudent.BNumber);
                    cmd.Parameters.AddWithValue("@Timings", ObjEStudent.Timings);
                    cmd.Parameters.AddWithValue("@Duration", ObjEStudent.Duration);
                    cmd.Parameters.AddWithValue("@AYear", ObjEStudent.AYear);
                    cmd.Parameters.AddWithValue("@Medium", ObjEStudent.Medium);
                    cmd.Parameters.AddWithValue("@PaymentMode", ObjEStudent.PaymentMode);
                    cmd.Parameters.AddWithValue("@Remarks", ObjEStudent.Remarks);
                    cmd.Parameters.AddWithValue("@EnquiryID", ObjEStudent.EnquiryID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCourse);
                    }
                    if (dsCourse != null && dsCourse.Tables.Count > 0)
                    {
                        int IVlaue = 0;
                        int FeeID = 0;
                        string str = Convert.ToString(dsCourse.Tables[0].Rows[0][0]);
                        string strFeeID = Convert.ToString(dsCourse.Tables[0].Rows[0][1]);
                        if (int.TryParse(str, out IVlaue) && int.TryParse(strFeeID, out FeeID))
                        {
                            ObjEStudent.StudentCourseMapID = IVlaue;
                            ObjEStudent.FeepaymentID = FeeID;
                            if (dsCourse != null && dsCourse.Tables.Count > 1)
                            {
                                ObjEStudent.dtCourse = dsCourse.Tables[1];
                                if (dsCourse != null && dsCourse.Tables.Count > 2)
                                    ObjEStudent.dtPayment = dsCourse.Tables[2];
                            }
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Student", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent GetCourse(EStudent ObjEStudent)
        {
            DataSet dsStudent = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_StudentCourseMap]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjEStudent.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsStudent);
                    }
                    if (dsStudent != null && dsStudent.Tables.Count > 0)
                        ObjEStudent.dtCourse = dsStudent.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Course List", ex);
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
                    cmd.CommandText = "[P_Ins_Feepayment]";
                    cmd.Parameters.AddWithValue("@FeepaymentID", ObjEStudent.FeepaymentID);
                    cmd.Parameters.AddWithValue("@StudentCourseMapID", ObjEStudent.StudentCourseMapID);
                    cmd.Parameters.AddWithValue("@Payment", ObjEStudent.Advance);
                    cmd.Parameters.AddWithValue("@DueDate", ObjEStudent.DueDate);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjEStudent.UserID);
                    cmd.Parameters.AddWithValue("@StudentID", ObjEStudent.StudentID);
                    cmd.Parameters.AddWithValue("@PaymentMode", ObjEStudent.PaymentMode);
                    cmd.Parameters.AddWithValue("@Remarks", ObjEStudent.Remarks);
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
                            ObjEStudent.FeepaymentID = IVlaue;
                            if (dsPayment != null && dsPayment.Tables.Count > 1)
                            {
                                ObjEStudent.dtPayment = dsPayment.Tables[1];
                                if (dsPayment != null && dsPayment.Tables.Count > 2)
                                    ObjEStudent.dtCourse = dsPayment.Tables[2];
                            }
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving Payment", ex);
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
                    cmd.CommandText = "[P_GEt_Feepayment]";
                    cmd.Parameters.AddWithValue("@StudentCourseMapID", ObjEStudent.StudentCourseMapID);
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
                throw new Exception("Error While Retrieving Payment List", ex);
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
                    cmd.CommandText = "[P_Ins_ImageData]";
                    cmd.Parameters.AddWithValue("@StudentID", ObjEStudent.StudentCourseMapID);
                    cmd.Parameters.AddWithValue("@ImageData", ObjEStudent.Imagedata);
                    cmd.Parameters.AddWithValue("@UserID", ObjEStudent.UserID);
                    Object obj =  cmd.ExecuteScalar();
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
                    cmd.CommandText = "[P_Ins_orgshortlogo]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEStudent.OrgID);
                    cmd.Parameters.AddWithValue("@ImageData", ObjEStudent.Imagedata);
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
                    cmd.CommandText = "[P_Ins_orglonglogo]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEStudent.OrgID);
                    cmd.Parameters.AddWithValue("@ImageData", ObjEStudent.Imagedata);
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
                    cmd.CommandText = "[P_Get_ImageData]";
                    cmd.Parameters.AddWithValue("@StudentID", ObjEStudent.StudentCourseMapID);
                    object obj = cmd.ExecuteScalar();
                    ObjEStudent.Imagedata = (byte[])obj;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Image", ex);
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
                    cmd.CommandText = "[P_Get_OrgshortLogo]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEStudent.OrgID);
                    object obj = cmd.ExecuteScalar();
                    ObjEStudent.Imagedata = (byte[])obj;
                }
            }
            catch (Exception ex){ throw ex; }
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
                    cmd.CommandText = "[P_Get_OrgLONGLogo]";
                    cmd.Parameters.AddWithValue("@OrgID", ObjEStudent.OrgID);
                    object obj = cmd.ExecuteScalar();
                    ObjEStudent.Imagedata = (byte[])obj;
                }
            }
            catch (Exception ex){ throw ex; }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent CancelAdmission(EStudent ObjEStudent)
        {
            DataSet dsCourse = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_CancelAdmission]";
                    cmd.Parameters.AddWithValue("@StudentCourseMapID", ObjEStudent.StudentCourseMapID);
                    cmd.Parameters.AddWithValue("@Remarks", ObjEStudent.Remarks);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCourse);
                    }
                    if (dsCourse != null && dsCourse.Tables.Count > 0)
                    {
                        int IVlaue = 0;
                        string str = Convert.ToString(dsCourse.Tables[0].Rows[0][0]);
                        if (int.TryParse(str, out IVlaue))
                        {
                            ObjEStudent.StudentCourseMapID = IVlaue;
                            if (dsCourse != null && dsCourse.Tables.Count > 1)
                            {
                                ObjEStudent.dtCourse = dsCourse.Tables[1];
                                if (dsCourse != null && dsCourse.Tables.Count > 2)
                                    ObjEStudent.dtPayment = dsCourse.Tables[2];
                            }
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjEStudent;
        }

        public EStudent SaveStudentEnquiry(EStudent ObjEStudent)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_StudentEnquiry]";
                    cmd.Parameters.AddWithValue("@StudentName", ObjEStudent.FullName);
                    cmd.Parameters.AddWithValue("@Mobile", ObjEStudent.CNumber);
                    cmd.Parameters.AddWithValue("@Course", ObjEStudent.course);
                    cmd.Parameters.AddWithValue("@Fees", ObjEStudent.fees_enquiry);
                    cmd.Parameters.AddWithValue("@UserID", ObjEStudent.UserID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjEStudent.BranchID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Saving", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

        public EStudent GetStudentByStudentCourceMapID(EStudent ObjEStudent)
        {
            DataSet dsStudent = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_StudentByStudentCourceMapID]";
                    cmd.Parameters.AddWithValue("@StudentCourseMapID", ObjEStudent.StudentCourseMapID);
                    cmd.Parameters.AddWithValue("@FeePaymentID", ObjEStudent.FeepaymentID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsStudent);
                    }
                    if (dsStudent != null && dsStudent.Tables.Count > 0)
                        ObjEStudent.dtStudentDetails = dsStudent.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Student Details", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }
    }
}
