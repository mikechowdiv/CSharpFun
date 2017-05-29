using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CommonEnd;

namespace Test
{
    public class Test
    {
        private Class1 arr = new Class1();
        [TestCase(new[] { 1, 2, 3 }, new[] { 7, 3 }, true)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 7, 3, 2 }, false)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 3 }, true)]

        public void Test1(int[] a, int[] b, bool expected)
        {
            var actual = arr.CommonEnd(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
