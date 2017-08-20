using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample2.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace Sample2.Data
{
    public class EmpRepo : IRepo
    {
        
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

        public bool Add(Employee employee)
        {
            try
            {
                string sql = "INSERT INTO Table1(name, mno) VALUES(@Name,@PhoneNumber); SELECT CAST(SCOPE_IDENTITY() AS INT)";
                var returnId = this.db.Query<int>(sql, employee).SingleOrDefault();
                employee.EmpId = returnId;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return this.db.Query<Employee>("SELECT * FROM Table1").ToList();
        }

        public Employee GetById(int id)
        {
            return this.db.Query<Employee>("SELECT * FROM Table1 WHERE Empid = @Empid", new { EmpId = id}).FirstOrDefault();
        }

        public bool Update(Employee employee, string ColumnName)
        {
            string query = "UPDATE Table1 SET " + ColumnName + "=@" + ColumnName + " WHERE EmpId=@EmpId";
            var count = this.db.Execute(query, employee);
            return count > 0;
        }
    }
}
