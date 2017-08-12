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
                Console.Write("enter employee ID: ");
                int empid = Convert.ToInt32(Console.ReadLine());

                Console.Write("enter employee name: ");
                string name = Console.ReadLine();

                Console.Write("enter employee salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                string query = "insert into emp values(" + empid + " ,'" + name + " '," + salary + ") ";
                Console.WriteLine(query);

                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\workspace\CSharpFun\SmallPrograms\ADOconnectDB\ADOconnectDB\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);

                conn.Open();
                Console.WriteLine("established connection");

                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine(result + " records inserted in emp table");

                Console.WriteLine("---for retreiving data---");
                query = "select * from emp";
                SqlCommand cmd1 = new SqlCommand(query, conn);

                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read() == true)
                {
                    int eid = reader.GetInt32(0); //0-column index [empid]
                    string rm = reader.GetString(1); //1-column index[name]
                    decimal sal = reader.GetDecimal(2); //2-column index[salary]
                    Console.WriteLine("{0}\t {1} \t {2}", eid, rm, sal);

                }

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
