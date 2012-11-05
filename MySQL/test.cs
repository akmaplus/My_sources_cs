using System;
//using System.Data;
//using MySql.Data;
using MySql.Data.MySqlClient;

public class App
{
    static string connStr = String.Format("server=localhost;user=root;password={0};charset=utf8", 
                            Environment.GetEnvironmentVariable("PasswMySql"));

    public static void Main()
    {   
        MySqlConnection conn = new MySqlConnection(connStr);

        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            // Perform database operations
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
    }
}
