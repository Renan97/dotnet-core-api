using System;
using System.Data;
using Npgsql;

namespace dotnet_core_api.Utils
{
    public class PostgreConnection
    {
        private string connectionString = "";


        public DataSet ExecuteQuery(string query)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();

                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return new DataSet();
        }
    }
}