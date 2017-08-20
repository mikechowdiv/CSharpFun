using Sample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2.Data
{
    public interface IRepo
    {
        List<Employee> GetAll();
        bool Add(Employee employee);
        Employee GetById(int id);
        bool Update(Employee employee, String ColumnName);
        bool Delete(int id);
    }
}
