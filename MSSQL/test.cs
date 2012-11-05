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

                using (SqlCommand cmd = new SqlCommand("SELECT * From Table1", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            Console.WriteLine("{0} {1} {2}", reader.GetInt32(0), reader.GetSqlString(1), reader.GetSqlString(2));
                    }
                }
            }
        }
        catch(SqlException ex)
        {
            Console.WriteLine(ex);
        }
    }
}
