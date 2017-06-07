using StudentMgtSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtSystem.Data
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
                while((line = sr.ReadLine()) != null)
                {
                    //1. create the studemt object.  2. split the line.  3. assign data to the object numbers.
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

        public void Add(Student student)
        {
            using(StreamWriter sw = new StreamWriter(_filePath, true))
            {
                string line = CreateCSV(student);
                sw.WriteLine(line);
            }
        }

        public void Edit(Student student, int index)
        {
            var students = List(); //load the students in
            students[index] = student; //get the student in that index and replace it with new data passed in.
            CreateStudentFile(students);
        }

        public void Delete(int index)
        {
            var students = List();
            students.RemoveAt(index); //RemoveAt() removes an item from a collection at an index
            CreateStudentFile(students);
        }


        //the easliest way to edit and delete is to re-write an entire text file
        private void CreateStudentFile(List<Student> students)
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath); //if the file exists, delete the file
            //open the streamWriter, write the headers and CSV lines for each student
            using(StreamWriter sr = new StreamWriter(_filePath))
            {
                sr.WriteLine("FirstName,LastName,Major,GPA");
                foreach(var items in students)
                {
                    sr.WriteLine(CreateCSV(items));
                }
            }
        }

        //utilite method - create CSV for student objects
        private string CreateCSV(Student student)
        {
            return string.Format("{0},{1},{2},{3}", student.FirstName, student.LastName, student.Major, student.GPA.ToString());
        }
    }
}
