using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleIOexercise.Data;
using ConsoleIOexercise.Models;

namespace Test
{
    [TestFixture]
    public class Test
    {
        private const string _filePath = @"E:\workspace\SG-works\videos\Student Management System\SystemIO\StudentTest.txt";

        [Test]
        public void CanRead()
        {
            StudentRepo repo = new StudentRepo(_filePath);
            List<Student> studentlist = repo.List();

            Assert.AreEqual(5, studentlist.Count());

            
        }
    }
}
