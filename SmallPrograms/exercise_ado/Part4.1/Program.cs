using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select Count(ProductId) from tblProduct";
                cmd.Connection = conn;
                conn.Open();
                int TotalRows = (int)cmd.ExecuteScalar();
                Console.WriteLine("Total Row = " + TotalRows.ToString());
                Console.ReadLine();
            }
        }
    }
}
