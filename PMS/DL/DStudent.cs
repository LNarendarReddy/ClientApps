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
                    cmd.Parameters.Add("@StudentID", ObjEStudent.StudentCourseMapID);
                    cmd.Parameters.Add("@ImageData", ObjEStudent.Imagedata);
                    cmd.Parameters.Add("@UserID", ObjEStudent.UserID);
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
                    cmd.CommandText = "[PMS_Ins_orgshortlogo]";
                    cmd.Parameters.Add("@OrgID", ObjEStudent.OrgID);
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
                    cmd.CommandText = "[PMS_Ins_orglonglogo]";
                    cmd.Parameters.Add("@OrgID", ObjEStudent.OrgID);
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
                    cmd.CommandText = "[P_Get_ImageData]";
                    cmd.Parameters.Add("@StudentID", ObjEStudent.StudentCourseMapID);
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
                    cmd.CommandText = "[PMS_Get_OrgshortLogo]";
                    cmd.Parameters.Add("@OrgID", ObjEStudent.OrgID);
                    object obj = cmd.ExecuteScalar();
                    ObjEStudent.Imagedata = (byte[])obj;
                }
            }
            catch (Exception ex){}
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
                    cmd.CommandText = "[PMS_Get_OrgLONGLogo]";
                    cmd.Parameters.Add("@OrgID", ObjEStudent.OrgID);
                    object obj = cmd.ExecuteScalar();
                    ObjEStudent.Imagedata = (byte[])obj;
                }
            }
            catch (Exception ex){}
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEStudent;
        }

    }
}
