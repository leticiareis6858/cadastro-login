using MySql.Data.MySqlClient;
using System;
using System.Data;

public class Database
{
    private string connectionString;

    public Database()
    {
        connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public DataTable ExecuteQuery(string query)
    {
        using (MySqlConnection conn = GetConnection())
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public int ExecuteNonQuery(string query)
    {
        using (MySqlConnection conn = GetConnection())
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
    public void CreateTables()
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS usuarios (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    usuario VARCHAR(50) NOT NULL,
                    senha VARCHAR(50) NOT NULL
                );";

            MySqlCommand cmd = new MySqlCommand(createTableQuery, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
