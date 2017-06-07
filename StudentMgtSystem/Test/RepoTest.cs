﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StudentMgtSystem.Data;
using StudentMgtSystem.Models;
using System.IO;

namespace Test
{
    [TestFixture]
   public class RepoTest
    {
        //seed file to preserve the original data.  StudentTest.txt is the actual file the unit test is run against.
        private const string _filePath = @"E:\workspace\CSharpFun\StudentMgtSystem\Data\StudentTest.txt";
        private const string _originalData = @"E:\workspace\CSharpFun\StudentMgtSystem\Data\StudentTestSeed.txt";

        [SetUp]
        //for re-setting your test data so the test will always work from sample data.
        public void Setup()
        {
            //everytime the test runs, delete the test data (StudentTest.txt) and restore the seed data.
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
            List<Student> students = repo.List();
            Assert.AreEqual(4, students.Count());

            Student check = students[2];
            Assert.AreEqual("Jane", check.FirstName);
            Assert.AreEqual("Doe", check.LastName);
            Assert.AreEqual("Computer Science", check.Major);
            Assert.AreEqual(4.0M, check.GPA);
        }
        [Test]
        public void CanAddStudents()
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

            Student check = students[4];
            Assert.AreEqual("Testy", check.FirstName);
            Assert.AreEqual("Tester", check.LastName);
            Assert.AreEqual("Research", check.Major);
            Assert.AreEqual(3.2M, check.GPA);
        }

        [Test]
        public void CanDelete()
        {
            StudentRepo repo = new StudentRepo(_filePath);
            repo.Delete(0);
            List<Student> students = repo.List();
            Assert.AreEqual(3, students.Count);

            Student check = students[0];
            Assert.AreEqual("Mary", check.FirstName);
            Assert.AreEqual("Jone", check.LastName);
            Assert.AreEqual("Business", check.Major);
            Assert.AreEqual(3.0M, check.GPA);
        }

        [Test]
        public void CanEdit()
        {
            StudentRepo repo = new StudentRepo(_filePath);
            List<Student> students = repo.List();

            Student editedStudent = students[0];
            editedStudent.GPA = 3.0M;
            repo.Edit(editedStudent, 0);
            
            Assert.AreEqual(4, students.Count);

            students = repo.List();
            Student check = students[0];

            Assert.AreEqual("Joe", check.FirstName);
            Assert.AreEqual("Smith", check.LastName);
            Assert.AreEqual("Computer Science", check.Major);
            Assert.AreEqual(3.0M, check.GPA);
        }
    }
}
