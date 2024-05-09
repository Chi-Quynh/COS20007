using System;
using System.Data;
using System.Data.SqlClient;

namespace CustomProject
{
    public class SqlTableConnector
    {
        private string connectionString = "Data Source=MSSQLSERVER01;Initial Catalog=your_database;Integrated Security=True;";

        public SqlTableConnector(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable ReadDataFromTable(string tableName)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = $"SELECT * FROM {tableName}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the error
                    Console.WriteLine($"Error reading data from table: {ex.Message}");
                    // You can also throw the exception here to propagate it to the caller
                    throw;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return dataTable;
        }

        public void WriteDataToTable(string tableName, DataRow data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = $"INSERT INTO {tableName} VALUES (@param1, @param2, @param3)"; // Replace with actual column names
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@param1", data["Column1"]);
                        command.Parameters.AddWithValue("@param2", data["Column2"]);
                        command.Parameters.AddWithValue("@param3", data["Column3"]);
                        // Add more parameters as needed

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Log the error
                    Console.WriteLine($"Error writing data to table: {ex.Message}");
                    // You can also throw the exception here to propagate it to the caller
                    throw;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
