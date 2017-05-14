using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SystemIO.Data;
using SystemIO.Models;

namespace SystemIO.Tests
{
    [TestFixture]
    public class RepoTests
    {
        private const string _filePath =
            @"E:\workspace\SG-works\videos\Student Management System\SystemIO\StudentTest.txt";

        private const string _originalData =
           @"E:\workspace\SG-works\videos\Student Management System\SystemIO\StudentTestSeed.txt";

        [SetUp]
        public void Setup()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
            File.Copy(_originalData, _filePath);
        }

        [Test]
        public void CanReadDataFromFile()
        {
            StudentRepo repo = new StudentRepo(_filePath);
            List <Student> students = repo.List();
            Assert.AreEqual(4, students.Count());

            Student check = students[2];
            Assert.AreEqual("Jane",check.FirstName);
            Assert.AreEqual("Doe",check.LastName);
            Assert.AreEqual("Computer Science",check.Major);
            Assert.AreEqual(4.0M, check.GPA);
        }

        [Test]
        public void CanAddStudentToFile()
        {
            StudentRepo repo = new StudentRepo(_filePath);
            Student newStudent = new Student();
            newStudent.FirstName = "Testy";
            newStudent.LastName = "Tester";
            newStudent.Major = "Research";
            newStudent.GPA = 3.2M;

            repo.Add(newStudent);

            List<Student> students = repo.List();
            Assert.AreEqual(5, students.Count());

            Student check = students[5];
            Assert.AreEqual("Testy", check.FirstName);
            Assert.AreEqual("Tester", check.LastName);
            Assert.AreEqual("Research", check.Major);
            Assert.AreEqual(3.2M, check.GPA);
        }

        [Test]
        public void CanDeleteStudent()
        {
            StudentRepo repo = new StudentRepo(_filePath);
            repo.Delete(0);

            List<Student> students = repo.List();
            Assert.AreEqual(3,students.Count);

            Student check = students[0];
            Assert.AreEqual("Mary", check.FirstName);
            Assert.AreEqual("Jone", check.LastName);
            Assert.AreEqual("Business", check.Major);
            Assert.AreEqual(3.0M, check.GPA);
        }
    }
}
