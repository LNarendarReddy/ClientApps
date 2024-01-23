using EL;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DAssessment
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public EAssessment GetProjectRatingsMaster(EAssessment ObjEAssessment)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectsRatingMaster]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        ObjEAssessment.dtAssessmentYear = ds.Tables[0];
                        if (ds != null && ds.Tables.Count > 1)
                        {
                            ObjEAssessment.dtProjects = ds.Tables[1];
                            if (ds != null && ds.Tables.Count > 2)
                            {
                                ObjEAssessment.dtCriteria = ds.Tables[2];
                                if (ds != null && ds.Tables.Count > 3)
                                {
                                    ObjEAssessment.dtLeads = ds.Tables[3];
                                    if (ds != null && ds.Tables.Count > 4)
                                    {
                                        ObjEAssessment.dtAssessmentMode = ds.Tables[4];
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Project Rating Master");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment SaveUserProject(EAssessment ObjEAssessment)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_ProjectRatings]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@ProjectUserMapID", ObjEAssessment.ProjectUserMapID);
                    cmd.Parameters.AddWithValue("@ProjectID", ObjEAssessment.ProjectID);
                    cmd.Parameters.AddWithValue("@AssessmentYear", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@SelfComments", ObjEAssessment.SelfComments);
                    cmd.Parameters.AddWithValue("@ManagementComments", ObjEAssessment.ManagementComments);
                    cmd.Parameters.AddWithValue("@dtRatings", ObjEAssessment.dtProjectRatings);
                    cmd.Parameters.AddWithValue("@LeadID", ObjEAssessment.LeadID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    object Objreturn = cmd.ExecuteScalar();
                    int Ivalue = 0;
                    if (int.TryParse(Convert.ToString(Objreturn), out Ivalue))
                        ObjEAssessment.ProjectUserMapID = Ivalue;
                    else
                        throw new Exception(Convert.ToString(Objreturn));

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetUserProject(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_UserPorjects]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtUserProjects = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving User Projects");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetUserProjectDetails(EAssessment ObjEAssessment)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectRatingsByID]";
                    cmd.Parameters.AddWithValue("@ProjectUserMapID", ObjEAssessment.ProjectUserMapID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        ObjEAssessment.ProjectID = ds.Tables[0].Rows[0]["ProjectID"];
                        ObjEAssessment.SelfComments = ds.Tables[0].Rows[0]["Selfcomments"];
                        ObjEAssessment.ManagementComments = ds.Tables[0].Rows[0]["ManagementComments"];
                        ObjEAssessment.LeadID = ds.Tables[0].Rows[0]["ProjectLeadID"];
                        if (ds.Tables.Count > 1)
                        {
                            ObjEAssessment.dtCriteria = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving User Project Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetGeneralRatings(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_GeneralRatings]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtGeneralRatings = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving General Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment SaveGeneralRatings(EAssessment ObjEAssessment)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_GeneralRatings]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@dtRatings", ObjEAssessment.dtGeneralRatingsUpdated);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetEmployeeBehaviourRatings(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_WorkPlacePerformanceRatings]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtWorkPlacePerformanceRatings = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Peer Review Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public object GetPeerReviewComments(EAssessment ObjEAssessment)
        {
            object objReturn = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_GET_PeerReviewComments]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    objReturn = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Peer Review Comments");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objReturn;
        }
        public EAssessment SaveEmployeeBehaviourRatings(EAssessment ObjEAssessment,object Comments)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_WorkplacePerformanceRatings]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@dtRatings", ObjEAssessment.dtWorkplacePerformanceRatingsUpdated);
                    cmd.Parameters.AddWithValue("@Comments", Comments);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetAssessmentYearforMS(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_AYearandUserforMS]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtAssessmentYear = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Assessment Years");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetAssessmentMode(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_AssessmentMode]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtAssessmentMode = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Assessment Mode");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetEmployeeforProjectRatings(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeforProjectRating]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@AssessmentyearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtEmployeeforPR = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetEmployeeforLR(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeforLRating]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@AssessmentyearID", ObjEAssessment.AssessMentYearID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtEmployeeforLR = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetEmployeeforGR(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeforGR]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtEmployeeforGR = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetUserProjectForMS(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectRatingsfoMS]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtUserProjects = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving User Projects");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetEmployeeforDS(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeForDS]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtEmployeeforDS = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetEmployeeRatingsforDS(EAssessment ObjEAssessment)
        {
            DataSet dS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_RatingsForDS]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dS);
                    }
                    if (dS != null && dS.Tables.Count > 0)
                    {
                        ObjEAssessment.dtUserProjectsForDS = dS.Tables[0];
                        if (dS.Tables.Count > 1)
                        {
                            ObjEAssessment.dtGeneralRatingsForDS = dS.Tables[1];
                        }
                        else
                            ObjEAssessment.dtGeneralRatingsForDS = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetEmployeeBehaviourRatingsForDS(EAssessment ObjEAssessment)
        {
            DataSet dS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_WorkPerformanceRatings]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dS);
                    }
                    if (dS != null && dS.Tables.Count > 0)
                        ObjEAssessment.dtEmployeeBehaviourRatingsForDS = dS.Tables[0];
                    else
                        ObjEAssessment.dtEmployeeBehaviourRatingsForDS = null;

                    if(dS != null && dS.Tables.Count > 1)
                    {
                        ObjEAssessment.SPeerReviewComments = dS.Tables[1].Rows[0]["SelfComments"];
                        ObjEAssessment.MPeerReviewComments = dS.Tables[1].Rows[0]["ManagementComments"];
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetTechnicalRatingsforDS(EAssessment ObjEAssessment)
        {
            DataSet dS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TechnicalRatingsForDS]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dS);
                    }
                    if (dS != null && dS.Tables.Count > 0)
                        ObjEAssessment.dtTechnicalRatingsForDS = dS.Tables[0];
                    else
                        ObjEAssessment.dtTechnicalRatingsForDS = null;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetUserProjectDetailsForDS(EAssessment ObjEAssessment)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectRatingsByIDForDS]";
                    cmd.Parameters.AddWithValue("@ProjectUserMapID", ObjEAssessment.ProjectUserMapID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        ObjEAssessment.ProjectID = ds.Tables[0].Rows[0]["ProjectID"];
                        ObjEAssessment.SelfComments = ds.Tables[0].Rows[0]["Selfcomments"];
                        ObjEAssessment.ManagementComments = ds.Tables[0].Rows[0]["ManagementComments"];
                        ObjEAssessment.LeadID = ds.Tables[0].Rows[0]["ProjectLeadID"];
                        if (ds.Tables.Count > 1)
                        {
                            ObjEAssessment.dtCriteria = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving User Project Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetLeadRatingsforDS(EAssessment ObjEAssessment)
        {
            DataSet dS = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeadRatingsForDS]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dS);
                    }
                    if (dS != null && dS.Tables.Count > 0)
                    {
                        ObjEAssessment.dtLeadRatingsForDS = dS.Tables[0];
                        if (dS.Tables.Count > 1)
                        {
                            ObjEAssessment.dtLeadCommentsForDS = dS.Tables[1];
                        }
                        else
                            ObjEAssessment.dtLeadCommentsForDS = null;
                    }
                    else
                    {
                        ObjEAssessment.dtLeadRatingsForDS = null;
                        ObjEAssessment.dtLeadCommentsForDS = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetTechnicalRatings(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TechnicalRatings]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtTechnicalRatings = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Technical Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment SaveTechnicalRatings(EAssessment ObjEAssessment)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_TechnicalRatings]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@dtRatings", ObjEAssessment.dtTechnicalRatingsUpdated);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetLeadRatings(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LeadRatings]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtLeadershipRatings = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Leadership Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment SaveLeadRatings(EAssessment ObjEAssessment)
        {
            DataSet dsUser = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_LeadRatings]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@dtRatings", ObjEAssessment.dtLeadershipRatingsUpdated);
                    cmd.Parameters.AddWithValue("@RatingUserID", ObjEAssessment.EmployeeID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment SaveWorkPlaceRatings(EAssessment ObjEAssessment)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_WorkPlaceRatings]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@Improvements", ObjEAssessment.Improvements);
                    cmd.Parameters.AddWithValue("@Appreciations", ObjEAssessment.Appreciations);
                    cmd.Parameters.AddWithValue("@AditionalContributions", ObjEAssessment.AditionalContributions);
                    cmd.Parameters.AddWithValue("@AdtionalRole", ObjEAssessment.AdtionalRole);
                    cmd.Parameters.AddWithValue("@dtRatings", ObjEAssessment.dtWorkplaceRAtings);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment SaveSelfGoals(EAssessment ObjEAssessment)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_SelfGoals]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    cmd.Parameters.AddWithValue("@AchivedGoals", ObjEAssessment.AchivedGoals);
                    cmd.Parameters.AddWithValue("@SelfGoalForYear", ObjEAssessment.SelfGoalForYear);
                    cmd.Parameters.AddWithValue("@SelfGoalforHalfYear", ObjEAssessment.SelfGoalforHalfYear);
                    cmd.Parameters.AddWithValue("@SelfGoalForHalfYearDetails", ObjEAssessment.SelfGoalForHalfYearDetails);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment SaveMGoals(EAssessment ObjEAssessment)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_MGoals]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@MGoalsAssessment", ObjEAssessment.MGoalsAssessment);
                    cmd.Parameters.AddWithValue("@MGoalForYear", ObjEAssessment.MGoalForYear);
                    cmd.Parameters.AddWithValue("@MGoalforHalfYear", ObjEAssessment.MGoalforHalfYear);
                    cmd.Parameters.AddWithValue("@MGoalForHalfYearDetails", ObjEAssessment.MGoalForHalfYearDetails);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetWorkPlaceRatings(EAssessment ObjEAssessment)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_WorkplaceRatings]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        ObjEAssessment.dtWorkplaceRAtings = ds.Tables[0].Copy();
                        if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                        {
                            ObjEAssessment.Improvements = ds.Tables[1].Rows[0]["Improvements"];
                            ObjEAssessment.Appreciations = ds.Tables[1].Rows[0]["Appreciations"];
                            ObjEAssessment.AditionalContributions = ds.Tables[1].Rows[0]["AditionalContributions"];
                            ObjEAssessment.AdtionalRole = ds.Tables[1].Rows[0]["AdtionalRole"];
                        }
                        else
                        {
                            ObjEAssessment.Improvements = null; ;
                            ObjEAssessment.Appreciations = null;
                            ObjEAssessment.AditionalContributions = 0;
                            ObjEAssessment.AdtionalRole = null;
                        }
                    }
                    else
                        ObjEAssessment.dtWorkplaceRAtings = new DataTable();


                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Workplace Ratings");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetSelfGoals(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_SelfGoals]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if (dt.Rows.Count > 0)
                    {
                        ObjEAssessment.AchivedGoals = dt.Rows[0]["AchivedGoals"];
                        ObjEAssessment.SelfGoalForYear = dt.Rows[0]["SelfGoalForYear"];
                        ObjEAssessment.SelfGoalforHalfYear = dt.Rows[0]["SelfGoalforHalfYear"];
                        ObjEAssessment.SelfGoalForHalfYearDetails = dt.Rows[0]["SelfGoalForHalfYearDetails"];
                    }
                    else
                    {
                        ObjEAssessment.AchivedGoals = null;
                        ObjEAssessment.SelfGoalForYear = null;
                        ObjEAssessment.SelfGoalforHalfYear = null;
                        ObjEAssessment.SelfGoalForHalfYearDetails = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Self Goals");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetMGoals(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_MGoals]";
                    cmd.Parameters.AddWithValue("@AssessmentYearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    cmd.Parameters.AddWithValue("@EmployeeID", ObjEAssessment.EmployeeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if (dt.Rows.Count > 0)
                    {
                        ObjEAssessment.MGoalsAssessment = dt.Rows[0]["MGoalsAssessment"];
                        ObjEAssessment.MGoalForYear = dt.Rows[0]["MGoalForYear"];
                        ObjEAssessment.MGoalforHalfYear = dt.Rows[0]["MGoalforHalfYear"];
                        ObjEAssessment.MGoalForHalfYearDetails = dt.Rows[0]["MGoalForHalfYearDetails"];
                    }
                    else
                    {
                        ObjEAssessment.MGoalsAssessment = null;
                        ObjEAssessment.MGoalForYear = null;
                        ObjEAssessment.MGoalforHalfYear = null;
                        ObjEAssessment.MGoalForHalfYearDetails = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Management Goals");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetRpeortingEmployees(EAssessment ObjEAssessment)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ReportingEmployees]";
                    cmd.Parameters.AddWithValue("@ReportingLeadID", ObjEAssessment.UserInfoID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    ObjEAssessment.dtReportingEmployees = dt;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
        public EAssessment GetEmployeeforMS(EAssessment ObjEAssessment)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_EmployeeforMA]";
                    cmd.Parameters.AddWithValue("@UserInfoID", ObjEAssessment.UserInfoID);
                    cmd.Parameters.AddWithValue("@AssessmentyearID", ObjEAssessment.AssessMentYearID);
                    cmd.Parameters.AddWithValue("@AssessmentModeID", ObjEAssessment.AssessMentModeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        ObjEAssessment.dtProjectEmployees = ds.Tables[0].Copy();
                        if (ds.Tables.Count > 1)
                            ObjEAssessment.dtAllEmployees = ds.Tables[1].Copy();
                        else
                            ObjEAssessment.dtAllEmployees = new DataTable();
                    }
                    else
                    {
                        ObjEAssessment.dtProjectEmployees = new DataTable();
                        ObjEAssessment.dtAllEmployees = new DataTable();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employees");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return ObjEAssessment;
        }
    }
}
 