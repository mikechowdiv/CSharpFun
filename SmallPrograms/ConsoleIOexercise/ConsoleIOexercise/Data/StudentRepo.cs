using ConsoleIOexercise.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIOexercise.Data
{
    public class StudentRepo
    {
        private string _filePath;

        public StudentRepo(string filePath)
        {
            _filePath = filePath;
        }

        public List<Student> List()
        {
            List<Student> students = new List<Student>();

            using (StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Student newStudent = new Student();

                    string[] columns = line.Split(',');
                    newStudent.FirstName = columns[0];
                    newStudent.LastName = columns[1];
                    newStudent.Major = columns[2];
                    newStudent.GPA = decimal.Parse(columns[3]);

                    students.Add(newStudent);
                }
            }
            return students;
        }

        
    }
}
