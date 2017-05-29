using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sum;

namespace Test
{
    [TestFixture]
    
   public class Test
    {
        private Class1 arr = new Class1();
        [TestCase(new[] { 1, 2, 3 }, 6)]
        [TestCase(new[] { 5, 11, 2 }, 18)]
        [TestCase(new[] { -7, 0, 0 }, -7)]

        public void SumTest(int[] nums, int expected)
        {
            var actual = arr.Sum(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
