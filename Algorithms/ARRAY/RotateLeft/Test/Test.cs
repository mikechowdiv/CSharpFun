using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RotateLeft;

namespace Test
{
    [TestFixture]
    public class Test
    {
        private Class1 arr = new Class1();
        [TestCase(new[] { 1, 2, 3 }, new[] { 2, 3, 1 })]
        [TestCase(new[] { 5, 11, 9 }, new[] { 11, 9, 5 })]
        [TestCase(new[] { 7, 0, 0 }, new[] { 0, 0, 7 })]

        public void RotateLeftTest(int[] nums, int[] expected)
        {
            var actual = arr.RotateLeft(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
