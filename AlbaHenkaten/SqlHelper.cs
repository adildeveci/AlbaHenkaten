using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AlbaHenkaten
{
    class SqlHelper
    {
        string connectionString = string.Empty;

        public SqlHelper()
        {
            try
            {
                connectionString = Properties.Settings.Default.ConnectionString;
            }
            catch (Exception)
            {
                //todo error handling  mechanism
                throw;
            }
        }



        public int ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] commandParameters)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(commandText, connection))
            {
                command.CommandType = commandType;
                command.Parameters.AddRange(commandParameters);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return result;
            }
        }

        public DataSet ExecuteQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(commandText, connection))
            {
                DataSet ds = new DataSet();
                command.CommandType = commandType;
                command.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);
                connection.Close();
                return ds;
            }
        }
    }
}
