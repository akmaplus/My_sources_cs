using System;
using System.Data.SqlClient;

class App
{   
    static string ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Dev\Tests\ConsoleApplication1\testdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

    static void Main(string[] args)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Table1 WHERE Name LIKE '555'", conn))
                {
                 int rowsAffected = cmd.ExecuteNonQuery();

                 Console.WriteLine(":{0}", rowsAffected);
                }
            }
        }
        catch(SqlException ex)
        {
            Console.WriteLine(ex);
        }
    }
}
