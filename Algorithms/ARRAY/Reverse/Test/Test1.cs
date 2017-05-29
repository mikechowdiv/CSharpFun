using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Reverse;

namespace Test
{
    [TestFixture]
    public class Test1
    {
        private Class1 arr = new Class1();

        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [TestCase(new[] { 5, 9, 11, 1 }, new[] { 1, 11, 9, 5 })]
        [TestCase(new[] { 7, 0, 0 }, new[] { 0, 0, 7 })]
        [TestCase(new[] { 7 }, new[] { 7 })]
        public void ReverseTest(int[] nums, int[] expected)
        {
            var actual = arr.Reverse(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
