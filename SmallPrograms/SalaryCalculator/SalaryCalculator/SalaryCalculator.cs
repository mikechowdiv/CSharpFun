using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class SalaryCalculator
    {
       
        const int Reg_time = 40;
        const double OT = 1.5;

        public SalaryCalculator(string name, double pay, double hours)
        {
            EmpName = name;
            EmpPay = pay;
            HoursWorked = hours;
        }

        public string EmpName { get; set; }
        public double EmpPay { get; set; }
        public double HoursWorked { get; set; }

        public double calcPay()
        {
            if (HoursWorked <= Reg_time)
                return HoursWorked * EmpPay;
            else
                return (Reg_time * EmpPay) + ((HoursWorked - Reg_time) * (EmpPay * OT));
        }

        public override string ToString()
        {
            return String.Format("Employee Name: {0}\nEmployee Hourly Pay: {1:C}\nEmployee Hours Worked: {2:N}\nEmployee Total Pay: {3:C}", 
                EmpName, EmpPay, HoursWorked, calcPay());
        }
    }
}
