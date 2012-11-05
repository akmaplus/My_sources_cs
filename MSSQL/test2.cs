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

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Table1(ID, Name) VALUES(@ID, @Name)", conn))
                {
                 cmd.Parameters.Add( new SqlParameter("@ID",   5) );
                 cmd.Parameters.Add( new SqlParameter("@Name", "555") );

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
