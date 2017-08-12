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
                cmd.CommandText = "INSERT INTO [dbo].[tblProduct] values (3, 'Acer', 1230, 33)";
                cmd.Connection = conn;
                conn.Open();
                int TotalRowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Total Row Inserted = " + TotalRowsAffected.ToString());
                Console.ReadLine();

                cmd.CommandText = "UPDATE [dbo].[tblProduct] SET [Qty] = 200 WHERE [ProductId] = 2";
                TotalRowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Total Row updated = " + TotalRowsAffected.ToString());
                Console.ReadLine();
            }

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
