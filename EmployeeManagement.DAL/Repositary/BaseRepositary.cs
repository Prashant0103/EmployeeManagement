using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EmployeeManagement.DAL.Repositary
{
    public class BaseRepositary<T> where T : class, new()
    {
        protected virtual string ConnectionString { get; set; }
        public BaseRepositary()
        {
            ConnectionString = this.GetConnectionString();
        }

        protected string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }


        protected string[] GetColumnNames(SqlDataReader dataReader)
        {
            return Enumerable.Range(0, dataReader.FieldCount).Select(dataReader.GetName).ToArray();
        }
        protected virtual List<T> ExecuteReader(string storedProcedureName, List<SqlParameter> sqlParameters, Action<T, SqlDataReader, string[]> setupRow, int timeOut) //where Y:class,new() Manual Ke liye
        {
            var resultList = new List<T>();
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(sqlParameters.ToArray());
                    command.CommandTimeout = timeOut;
                    connection.Open();
                    using (var dataReader = command.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        while (dataReader.Read())
                        {
                            var newObect = new T();
                            var columnNames = this.GetColumnNames(dataReader);
                            setupRow(newObect, dataReader, columnNames);
                            resultList.Add(newObect);
                        }
                    }
                }
            }
            return resultList;
        }

        protected virtual List<Y> ManualExecuteReader<Y>(string storedProcedureName, List<SqlParameter> sqlParameters, Action<Y, SqlDataReader, string[]> setupRow, int timeOut) where Y : class, new()
        {
            var resultList = new List<Y>();
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(sqlParameters.ToArray());
                    command.CommandTimeout = timeOut;
                    connection.Open();
                    using (var dataReader = command.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        while (dataReader.Read())
                        {
                            var newObect = new Y();
                            var columnNames = this.GetColumnNames(dataReader);
                            setupRow(newObect, dataReader, columnNames);
                            resultList.Add(newObect);
                        }
                    }
                }
            }
            return resultList;
        }

        protected virtual Y ExecuteScalar<Y>(string storedProcedureName, List<SqlParameter> sqlParameters, int timeOut)
        {
            var result = default(Y);
            using (var connection = new SqlConnection(this.ConnectionString))
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(sqlParameters.ToArray());
                    command.CommandTimeout = timeOut;
                    connection.Open();
                    var objResult = command.ExecuteScalar();
                    result = (Y)objResult;
                }
            }
            return result;
        }

        protected virtual int ExecuteNonQuery(string storedProcedureName, List<SqlParameter> sqlParameters, int timeOut)
        {

            using (var connection = new SqlConnection(this.ConnectionString))
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(sqlParameters.ToArray());
                    command.CommandTimeout = timeOut;
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }
        protected int GetColumnOrdinal(string[] columnNameList, string columnName)
        {
            for (int i = 0; i < columnNameList.Length; i++)
            {
                if (string.Equals(columnName, columnNameList[i], StringComparison.InvariantCultureIgnoreCase))
                    return i;
            }
            return -1;
        }
    }
}
