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
            throw new NotImplementedException();
        }

        public List<Contacts> GetAll()
        {
            return this.db.Query<Contacts>("SELECT * FROM Contacts").ToList();
        }

        public Contacts GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contacts contacts, string ColumnName)
        {
            throw new NotImplementedException();
        }
    }
}
