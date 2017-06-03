using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Department
    {
        private string deptName;
        private double deptBudget;
        private int i = 0;

        Employee[] emp = new Employee[5];

        public void AddEmployee(Employee person)
        {
            emp[i] = person;
            i++;
            if (person.empGrade > 5) deptBudget += 150000;
            else
            {
                deptBudget += 100000;
            }
        }

        public void describe()
        {
            string temp = "Department : " + deptName + 
                "\nthe total budget is: " + deptBudget + "\nEmployee : ";

            foreach(Employee items in emp)
            {
                if(items != null)
                {
                    temp += items.ReturnNameGrade() + " ";
                }
                
            }

            Console.WriteLine(temp);
        }
        public Department(string name)
        {
            deptName = name;
            deptBudget = 50000;
        }
    }
}
