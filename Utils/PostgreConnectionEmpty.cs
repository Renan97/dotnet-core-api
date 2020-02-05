using System;
using System.Data;
using Npgsql;

namespace dotnet_core_api.Utils
{
    public class PostgreConnectionEmpty
    {
        public NpgsqlConnection GetConnection()
        {
            string connectionString = "";
            return new NpgsqlConnection(connectionString);
        }

        public DataSet ExecuteQuery(NpgsqlConnection connection, string query)
        {
            try
            {
                var result = "";
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