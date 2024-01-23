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
    public class DCourse
    {
        public ECourse SaveCourse(ECourse ObjECourse)
        {
            DataSet dsCourse = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Ins_Course]";
                    cmd.Parameters.AddWithValue("@CourseID", ObjECourse.CourseID);
                    cmd.Parameters.AddWithValue("@OrgID", ObjECourse.OrgID);
                    cmd.Parameters.AddWithValue("@BranchID", ObjECourse.BranchID);
                    cmd.Parameters.AddWithValue("@Name", ObjECourse.Name);
                    cmd.Parameters.AddWithValue("@ShortName", ObjECourse.ShortName);
                    cmd.Parameters.AddWithValue("@Duration", ObjECourse.Duration);
                    cmd.Parameters.AddWithValue("@Fees", ObjECourse.Fees);
                    cmd.Parameters.AddWithValue("@CreatedBy", ObjECourse.UserID);
                    cmd.Parameters.AddWithValue("@MainCourseName", ObjECourse.MainCourseName);
                    cmd.Parameters.AddWithValue("@MainCourseID", ObjECourse.MainCourseID);
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
                            ObjECourse.CourseID = IVlaue;
                            if (dsCourse != null && dsCourse.Tables.Count > 1)
                                ObjECourse.dtCourse = dsCourse.Tables[1];
                        }
                        else
                            throw new Exception(str);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_CName"))
                    throw new Exception("Course Already Exists!!");
                else
                    throw new Exception("Error While Saving Course");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjECourse;
        }

        public ECourse GetCourse(ECourse ObjECourse)
        {
            DataSet dsCourse = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_Course]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjECourse.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCourse);
                    }
                    if (dsCourse != null && dsCourse.Tables.Count > 0)
                        ObjECourse.dtCourse = dsCourse.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Course List",ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjECourse;
        }

        public ECourse GetMainCourse(ECourse ObjECourse)
        {
            DataSet dsCourse = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Get_MainCourse]";
                    cmd.Parameters.AddWithValue("@BranchID", ObjECourse.BranchID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsCourse);
                    }
                    if (dsCourse != null && dsCourse.Tables.Count > 0)
                        ObjECourse.dtMainCourse = dsCourse.Tables[0];
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
            return ObjECourse;
        }

        public ECourse DeleteCourse(ECourse ObjECourse)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[P_Del_Course]";
                    cmd.Parameters.AddWithValue("@CourseID", ObjECourse.CourseID);
                    object objReturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    if (!int.TryParse(Convert.ToString(objReturn), out ivalue))
                        throw new Exception(Convert.ToString(objReturn));
                        

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Deleteing Course", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjECourse;
        }
    }
}
