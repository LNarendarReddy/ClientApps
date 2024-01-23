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
    public class DProject
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public EProject GetUsers(EProject objEProject)
        {
            objEProject.dtUsers = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_User]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtUsers);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving User List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetProjects(EProject objEProject)
        {
            objEProject.dtProjects = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Project]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtProjects);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Project List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveProjectList(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtProjects = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Project]";
                    cmd.Parameters.AddWithValue("@ProjectID", objEProject.ProjectID);
                    cmd.Parameters.AddWithValue("@ProjectName", objEProject.ProjectName);
                    cmd.Parameters.AddWithValue("@ProjectLeadID", objEProject.ProjectLeadID);
                    cmd.Parameters.AddWithValue("@IsActive", objEProject.IsActive);
                    cmd.Parameters.AddWithValue("@ClientName", objEProject.ClientName);
                    cmd.Parameters.AddWithValue("@SourceCodePath", objEProject.SourceCodePath);
                    cmd.Parameters.AddWithValue("@JiraProject", objEProject.JiraProject);
                    cmd.Parameters.AddWithValue("@ProjectShortName", objEProject.ProjectShortName);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stProjectID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stProjectID, out ivalue))
                        {
                            objEProject.ProjectID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtProjects = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                if (ex.Message.Contains("UC_Project_ProjectShortName"))
                    throw new Exception("Project Short Name Already Exists!");
                else
                    throw new Exception("Error While Saving Project");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetProjectPhase(EProject objEProject)
        {
            objEProject.dtPhase = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectPhase]";
                    cmd.Parameters.AddWithValue("@ProjectID", objEProject.ProjectID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtPhase);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Phase List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveProjectPhase(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtPhase = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_ProjectPhase]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    cmd.Parameters.AddWithValue("@ProjectID", objEProject.ProjectID);
                    cmd.Parameters.AddWithValue("@PhaseName", objEProject.PhaseName);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    cmd.Parameters.AddWithValue("@IsActive", objEProject.IsActive);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stProjectID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stProjectID, out ivalue))
                        {
                            objEProject.ProjectPhaseID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtPhase = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                if (ex.Message.Contains("Phase already exists"))
                    throw ex;
                else
                    throw new Exception("Error While Saving Project Phase");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetProjectTeam(EProject objEProject)
        {
            objEProject.dtTeam = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ProjectEmployee]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtTeam);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Employee List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveProjectTeam(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtTeam = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_ProjectEmployee]";
                    cmd.Parameters.AddWithValue("@ProjectEmployeeID", objEProject.ProjectEmployeeID);
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    cmd.Parameters.AddWithValue("@EmployeeID", objEProject.EmployeeID);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    cmd.Parameters.AddWithValue("@IsActive", objEProject.IsActive);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string stProjectID = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(stProjectID, out ivalue))
                        {
                            objEProject.ProjectEmployeeID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtTeam = ds.Tables[1];
                        }
                        else
                            throw new Exception(stProjectID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                if (ex.Message.Contains("Selected"))
                    throw ex;
                else
                    throw new Exception("Error While Saving Project Team");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetComponent(EProject objEProject)
        {
            objEProject.dtComponent = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Component]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtComponent);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Component List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveComponent(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtComponent = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Component]";
                    cmd.Parameters.AddWithValue("@ComponentID", objEProject.ComponentID);
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    cmd.Parameters.AddWithValue("@ComponentName", objEProject.ComponentName);
                    cmd.Parameters.AddWithValue("@ComponentDescription", objEProject.ComponentDescription);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string st = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(st, out ivalue))
                        {
                            objEProject.ComponentID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtComponent = ds.Tables[1];
                        }
                        else
                            throw new Exception(st);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Saving Component");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetComponentDescription(EProject objEProject)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ComponentDescription]";
                    cmd.Parameters.AddWithValue("@ComponentID", objEProject.ComponentID);
                    objEProject.ComponentDescription = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Component Description");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetChangeLog(EProject objEProject)
        {
            objEProject.dtChangeLog = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_GeT_ChangeLog]";
                    cmd.Parameters.AddWithValue("@ID", objEProject.ID);
                    cmd.Parameters.AddWithValue("@Type", objEProject.Type);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtChangeLog);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Change Log");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject DeleteComponent(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtComponent = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Del_Component  ]";
                    cmd.Parameters.AddWithValue("@ComponentID", objEProject.ComponentID);
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string st = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(st, out ivalue))
                        {
                            objEProject.ComponentID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtComponent = ds.Tables[1];
                        }
                        else
                            throw new Exception(st);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Deleting Component");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetComponentforDropDown(EProject objEProject)
        {
            objEProject.dtComponentfroDropDown = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ComponentForDropDown]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtComponentfroDropDown);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Component List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetRequirement(EProject objEProject)
        {
            objEProject.dtRequirement = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Requirement]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtRequirement);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Requirement List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveRequirement(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtRequirement = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Requirement]";
                    cmd.Parameters.AddWithValue("@ComponentID", objEProject.ComponentID);
                    cmd.Parameters.AddWithValue("@RequirementID", objEProject.RequirementID);
                    cmd.Parameters.AddWithValue("@RequirementName", objEProject.RequirementName);
                    cmd.Parameters.AddWithValue("@RDescription", objEProject.RDescription);
                    cmd.Parameters.AddWithValue("@Description", objEProject.Description);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string st = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(st, out ivalue))
                        {
                            objEProject.RequirementID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtRequirement = ds.Tables[1];
                        }
                        else
                            throw new Exception(st);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Saving Requirement");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetRequirementDescription(EProject objEProject)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_RequirementDescription]";
                    cmd.Parameters.AddWithValue("@RequirementID", objEProject.RequirementID);
                    objEProject.ComponentDescription = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Requirement Description");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetScenario(EProject objEProject)
        {
            objEProject.dtScenario = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Scenario]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtScenario);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Scenario List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveScenario(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtScenario = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Scenario]";
                    cmd.Parameters.AddWithValue("@RequirementID", objEProject.RequirementID);
                    cmd.Parameters.AddWithValue("@ScenarioID", objEProject.ScenarioID);
                    cmd.Parameters.AddWithValue("@Shortdescription", objEProject.SShortDescription);
                    cmd.Parameters.AddWithValue("@LongDescription", objEProject.SLongDescription);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string st = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(st, out ivalue))
                        {
                            objEProject.ScenarioID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtScenario = ds.Tables[1];
                        }
                        else
                            throw new Exception(st);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Saving Scenario");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetScenarioDescription(EProject objEProject)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ScenarioDescription]";
                    cmd.Parameters.AddWithValue("@ScenarioID", objEProject.ScenarioID);
                    objEProject.SLongDescription = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Scenario Description");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetRequirementForDropDown(EProject objEProject)
        {
            objEProject.dtRequirementforDropDown = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_RequirementForDropDown]";
                    cmd.Parameters.AddWithValue("@ComponentID", objEProject.ComponentID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtRequirementforDropDown);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Requirement List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetTestcase(EProject objEProject)
        {
            objEProject.dtTestcase = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_Testcase]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtTestcase);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Testcase List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveTestcase(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtTestcase = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_Testcase]";
                    cmd.Parameters.AddWithValue("@TestcaseID", objEProject.TestcaseID);
                    cmd.Parameters.AddWithValue("@ScenarioID", objEProject.ScenarioID);
                    cmd.Parameters.AddWithValue("@TestcaseName", objEProject.TestcaseName);
                    cmd.Parameters.AddWithValue("@Complexity", objEProject.Complexity);
                    cmd.Parameters.AddWithValue("@Severity", objEProject.Severity);
                    cmd.Parameters.AddWithValue("@TestcaseType", objEProject.TestcaseType);
                    cmd.Parameters.AddWithValue("@RegressionRequired", objEProject.RegressionRequired);
                    cmd.Parameters.AddWithValue("@TestSteps", objEProject.TestSteps);
                    cmd.Parameters.AddWithValue("@ExpectedResult", objEProject.ExpectedResult);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string st = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(st, out ivalue))
                        {
                            objEProject.TestcaseID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtTestcase = ds.Tables[1];
                        }
                        else
                            throw new Exception(st);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Saving Testcase");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetScenarioForDropDown(EProject objEProject)
        {
            objEProject.dtScenarioforDropDown = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_ScenarioForDropDown]";
                    cmd.Parameters.AddWithValue("@RequirementID", objEProject.RequirementID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtScenarioforDropDown);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Scenario List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetTestcaseDescription(EProject objEProject)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TestcaseDescription]";
                    cmd.Parameters.AddWithValue("@TestcaseID", objEProject.TestcaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        objEProject.ExpectedResult = dt.Rows[0]["ExpectedResult"];
                        objEProject.TestSteps = dt.Rows[0]["TestSteps"];
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Testcase Description");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetDevBuild(EProject objEProject)
        {
            objEProject.dtDevBuilds = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_DevBuild]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtDevBuilds);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Build List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveDevBuild(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtDevBuilds = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_DevBuild]";
                    cmd.Parameters.AddWithValue("@DevBuildID", objEProject.DevBuildID);
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    cmd.Parameters.AddWithValue("@ProjectID", objEProject.ProjectID);
                    cmd.Parameters.AddWithValue("@BuildVersion", objEProject.BuildVersion);
                    cmd.Parameters.AddWithValue("@BuildPath", objEProject.BuildPath);
                    cmd.Parameters.AddWithValue("@ImpactAnalysis", objEProject.ImpactAnalysis);
                    cmd.Parameters.AddWithValue("@ImpactModules", objEProject.ImpactModules);
                    cmd.Parameters.AddWithValue("@BuildChanges", objEProject.BuildChanges);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string st = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(st, out ivalue))
                        {
                            objEProject.DevBuildID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtDevBuilds = ds.Tables[1];
                        }
                        else
                            throw new Exception(st);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Saving Build");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetQABuild(EProject objEProject)
        {
            objEProject.dtQABuilds = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_DevBuildForQA]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtQABuilds);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Build List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject SaveSelectedTestcases(EProject objEProject)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Ins_SelectedTestcases]";
                    cmd.Parameters.AddWithValue("@DevBuildID", objEProject.DevBuildID);
                    cmd.Parameters.AddWithValue("@dtTestcases", objEProject.dtSelectedCases);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    object objreturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    string st = Convert.ToString(objreturn);
                    if (int.TryParse(st, out ivalue))
                    {
                        objEProject.DevBuildID = ivalue;
                    }
                    else
                        throw new Exception(st);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Saving Build");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetTestcaseForQA(EProject objEProject)
        {
            objEProject.dtTestcaseForQA = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TestExecution]";
                    cmd.Parameters.AddWithValue("@DevBuildID", objEProject.DevBuildID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtTestcaseForQA);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Testcase List");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetTestcaseDetails(EProject objEProject)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TestcaseDetails]";
                    cmd.Parameters.AddWithValue("@TestExecutionID", objEProject.TestExecutionID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    if(dt != null && dt.Rows.Count > 0)
                    {
                        objEProject.TestcaseID = dt.Rows[0]["TestcaseID"];
                        objEProject.TestcaseName = dt.Rows[0]["TestcaseName"];
                        objEProject.Complexity = dt.Rows[0]["Complexity"];
                        objEProject.Severity = dt.Rows[0]["Severity"];
                        objEProject.TestcaseType = dt.Rows[0]["TestcaseType"];
                        objEProject.RegressionRequired = dt.Rows[0]["RegressionRequired"];
                        objEProject.TestSteps = dt.Rows[0]["TestSteps"];
                        objEProject.ExpectedResult = dt.Rows[0]["ExpectedResult"];
                        objEProject.TestExecutionID = dt.Rows[0]["TestExecutionID"];
                        objEProject.Testdata = dt.Rows[0]["Testdata"];
                        objEProject.Testdate = dt.Rows[0]["Testdate"];
                        objEProject.TestStatus = dt.Rows[0]["TestStatus"];
                        objEProject.Comments = dt.Rows[0]["Comments"];
                        objEProject.ScenarioID = dt.Rows[0]["Scenario"];
                        objEProject.RequirementID = dt.Rows[0]["RequirementName"];
                        objEProject.ComponentID = dt.Rows[0]["ComponentName"];
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Testcase Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject UpdateTestcase(EProject objEProject)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_Testcase]";
                    cmd.Parameters.AddWithValue("@TestExecutionID", objEProject.TestExecutionID);
                    cmd.Parameters.AddWithValue("@Testdata", objEProject.Testdata);
                    cmd.Parameters.AddWithValue("@TestStatus", objEProject.TestStatus);
                    cmd.Parameters.AddWithValue("@Comments", objEProject.Comments);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    object objreturn = cmd.ExecuteScalar();
                    int ivalue = 0;
                    string st = Convert.ToString(objreturn);
                    if (int.TryParse(st, out ivalue))
                    {
                        objEProject.TestExecutionID = ivalue;
                    }
                    else
                        throw new Exception(st);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Updating Testcase");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject CompleteQA(EProject objEProject)
        {
            DataSet ds = new DataSet();
            objEProject.dtQABuilds = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Upd_CompleteQA]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", objEProject.ProjectPhaseID);
                    cmd.Parameters.AddWithValue("@DevBuildID", objEProject.DevBuildID);
                    cmd.Parameters.AddWithValue("@QAComments", objEProject.QAComments);
                    cmd.Parameters.AddWithValue("@UserID", objEProject.UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        int ivalue = 0;
                        string st = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        if (int.TryParse(st, out ivalue))
                        {
                            objEProject.DevBuildID = ivalue;
                            if (ds.Tables.Count > 1)
                                objEProject.dtQABuilds = ds.Tables[1];
                        }
                        else
                            throw new Exception(st);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Updating QA comments");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetTestExecutionLog(EProject objEProject)
        {
            objEProject.dtTestExecutionLog = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_TestExecutionLog]";
                    cmd.Parameters.AddWithValue("@TestExecutionID", objEProject.TestExecutionID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtTestExecutionLog);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Test Execution Log");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetChanges(EProject objEProject)
        {
            objEProject.dtChanges = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Get_LogDescription]";
                    cmd.Parameters.AddWithValue("@ID", objEProject.ID);
                    cmd.Parameters.AddWithValue("@Type", objEProject.Type);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dtChanges);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Changes");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetQAReport_DevBuild(EProject objEProject)
        {
            objEProject.dsQAReport_DevBuild = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Rpt_DevBuild]";
                    cmd.Parameters.AddWithValue("@DevBuildID", objEProject.DevBuildID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dsQAReport_DevBuild);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving DevBuild Details");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetQAReport_ProjectTeam(EProject objEProject)
        {
            objEProject. dsQAReport_ProjectTeam= new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Rpt_ProjectTeam]";
                    cmd.Parameters.AddWithValue("@DevBuildID", objEProject.DevBuildID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dsQAReport_ProjectTeam);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Project Team");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public EProject GetQAReport_TestExecution(EProject objEProject)
        {
            objEProject.dsQAReport_TestExecution = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_Rpt_TestExecution]";
                    cmd.Parameters.AddWithValue("@DevBuildID", objEProject.DevBuildID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(objEProject.dsQAReport_TestExecution);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw new Exception("Error While Retrieving Test Execution");
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return objEProject;
        }
        public void CopyTestCases(object FromProjectPhaseID,object ToProjectPhaseID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_INS_COPYTESTCASES]";
                    cmd.Parameters.AddWithValue("@FromProjectPhaseID", FromProjectPhaseID);
                    cmd.Parameters.AddWithValue("@ToProjectPhaseID", ToProjectPhaseID);
                    int ivalue = cmd.ExecuteNonQuery();
                    if (ivalue == 0)
                        throw new Exception("Error While Copying Testcases");
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
        }
        public void ImportTestCases(object ProjectPhaseID
            ,DataTable   dtComponent, DataTable dtRequirement
            , DataTable dtScenario, DataTable dtTestCase,object UserID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_IMP_TESTCASES]";
                    cmd.Parameters.AddWithValue("@ProjectPhaseID", ProjectPhaseID);
                    cmd.Parameters.AddWithValue("@dtComponent", dtComponent);
                    cmd.Parameters.AddWithValue("@dtRequirement", dtRequirement);
                    cmd.Parameters.AddWithValue("@dtScneario", dtScenario);
                    cmd.Parameters.AddWithValue("@dtTestcase", dtTestCase);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    object objrEturn = cmd.ExecuteScalar();
                    if (!int.TryParse(Convert.ToString(objrEturn), out int ivalue))
                        throw new Exception(Convert.ToString(objrEturn));
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
        }
    }
}
