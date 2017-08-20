using Sample2.Data;
using Sample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2.Workflows
{
    public class UpdateWorkflow
    {
        public static IRepo empRepository = new EmpRepo();

        public void Exe()
        {
            Console.WriteLine("Please input the ID you want to update");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name press 1");
            Console.Write("Phone # press 2");
            int ch = Convert.ToInt32(Console.ReadLine());
            Employee emp = empRepository.GetById(id);
            String TitleName = null;
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Name: ");
                    string nameInput = Console.ReadLine();
                    emp.Name = nameInput;
                    TitleName = "Name";
                    empRepository.Update(emp, TitleName);
                    GetById(id);
                    break;
                case 2:
                    Console.WriteLine("Phone: ");
                    string phoneInput = Console.ReadLine();
                    emp.PhoneNumber = phoneInput;
                    TitleName = "PhoneNumber";
                    empRepository.Update(emp, TitleName);
                    GetById(id);
                    break;
                default:
                    Console.WriteLine("Please select");
                    break;
            }
        }

        public void GetById(int id)
        {
            Employee emp = empRepository.GetById(id);
            if (emp != null)
            {
                Console.WriteLine(emp.EmpId + " " + emp.Name + " " + emp.PhoneNumber);
            }
        }
    }
}
