using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace Data
{
    public class ContactsRepo : IContactsRepo
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

        public bool Add(Contacts contacts)
        {
            try
            {
                string sql = "INSERT INTO Contacts(FirstName,LastName,Company,Title) values(@FirstName,@LastName,@Company,@Title); SELECT CAST(SCOPE_IDENTITY() as int)";
                var returnId = this.db.Query<int>(sql, contacts).SingleOrDefault();
                contacts.Id = returnId;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            var affectedRows = this.db.Execute("DELETE FROM Contacts WHERE Id=@Id", new { Id = id });
            return affectedRows > 0;
        }

        public List<Contacts> GetAll()
        {
            return this.db.Query<Contacts>("SELECT * FROM Contacts").ToList();
        }

        public Contacts GetById(int id)
        {
            return this.db.Query<Contacts>("SELECT * FROM Contacts WHERE Id=@Id", new { Id = id }).FirstOrDefault();
        }

        public bool Update(Contacts contacts, string ColumnName)
        {
            string query = "UPDATE Contacts SET " + ColumnName + "=@" + ColumnName + " WHERE Id=@Id";
            var count = this.db.Execute(query, contacts);
            return count > 0;
        }
    }
}
