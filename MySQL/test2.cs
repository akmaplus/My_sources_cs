using System;
using MySql.Data;
using MySql.Data.MySqlClient;

public class App
{
    static string connStr = String.Format("server=localhost;user=root;password={0};charset=utf8", 
                            Environment.GetEnvironmentVariable("PasswMySql"));
    static MySqlConnection conn;

    public static void Main()
    {
      if(Connect()==true) 
      {
        Test();
        Disconnect();
      }
    }
    public static bool Connect()
    {
        conn = new MySqlConnection(connStr);
        try
        {
            conn.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("{0} {1}", ex.Number, ex.Message);
            return false;
        }
    }
    public static void Disconnect()
    {
      conn.Close();
    }
    public static void Test()
    {
      string sql = "SELECT VERSION()";

      MySqlCommand cmd = new MySqlCommand(sql, conn);

      MySqlDataReader rdr = cmd.ExecuteReader();

      while (rdr.Read())
      {
          Console.WriteLine("MySQL version: {0}", rdr[0]);
      }
      rdr.Close();

    }
}
