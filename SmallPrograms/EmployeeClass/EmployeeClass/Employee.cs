using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Employee
    {
        private string empName;
        public int empGrade { private set; get; }

        public Employee(string name, int grade)
        {
            empName = name;
            empGrade = grade;
        }

        public string ReturnNameGrade()
        {
            string temp = empName + "(" + empGrade + ")";
            return temp;
        }
    }
}
