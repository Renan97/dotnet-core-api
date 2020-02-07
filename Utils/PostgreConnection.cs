using System;
using System.Data;
using Npgsql;
using System.Configuration;

namespace dotnet_core_api.Utils
{
    public class PostgreConnection
    {
        private string connectionString;
        public PostgreConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString;
        }

        public DataSet ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            var dataSet = new DataSet();
            try
            {
                connection.Open();
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet);

            }
            catch (Exception ex)
            {
                return new DataSet();
            }
            finally
            {
                connection.Close();
            }
            return dataSet;
        }
    }
}