using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IContactsRepo
    {
        List<Contacts> GetAll();
        bool Add(Contacts contacts);
        Contacts GetById(int id);
        bool Update(Contacts contacts, String ColumnName);
        bool Delete(int id);
    }
}
