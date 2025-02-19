using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        
string connectionString = "server=82.112.229.208;port=3306;database=u376928149_employee;user=u376928149_root;password=Contact@os#2024;";
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected to MySQL successfully!");

                // Run a sample query
                string query = "SELECT VERSION()";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                string version = cmd.ExecuteScalar().ToString();
                Console.WriteLine("MySQL Version: " + version);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}