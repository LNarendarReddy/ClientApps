using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMaker.Repository
{
    internal class RepositoryBase
    {
        #region Public Methods

        public DataTable GetDataTable(string procedureName, Dictionary<string, object> parameters = null)
        {
            return GetDataset(procedureName, parameters).Tables[0];
        }

        public DataSet GetDataset(string procedureName, Dictionary<string, object> parameters = null)
        {
            DataSet dsReportData = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandTimeout = 1800;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procedureName;
                    ProcessParameters(cmd, parameters);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsReportData);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error While Retrieving {procedureName}", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dsReportData;
        }

        public T Execute<T>(string procedureName, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                { 
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procedureName;
                    ProcessParameters(cmd, parameters);
                    object objReturn = cmd.ExecuteScalar();

                    if (objReturn == null) return default(T);

                    string returnString = objReturn.ToString();
                    Type expectedType = typeof(T);
                    if (expectedType == typeof(int))
                    {
                        if (!int.TryParse(returnString, out int ID))
                        {
                            throw new Exception(returnString);
                        }

                        return (T)Convert.ChangeType(ID, typeof(T));
                    }
                    else if (expectedType == typeof(string))
                    {
                        return (T)Convert.ChangeType(returnString, typeof(T));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return default(T);
        }

        #endregion

        #region Private Methods

        private void ProcessParameters(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            if (parameters == null) return;

            foreach (var param in parameters)
            {
                string paramName = param.Key;
                paramName = paramName.StartsWith("@") ? paramName : $"@{paramName}";
                sqlCommand.Parameters.AddWithValue(paramName, param.Value);
            }
        }

        #endregion
    }
}
