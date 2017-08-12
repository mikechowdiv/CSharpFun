using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOconnectDB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\workspace\CSharpFun\SmallPrograms\ADOconnectDB\ADOconnectDB\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);

                conn.Open();
                Console.WriteLine("established connection");
                conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();
        }
    }
}
