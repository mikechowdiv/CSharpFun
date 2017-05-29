using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FirstLast6;

namespace Test
{
    [TestFixture]
    public class Test
    {
        private Class1 _arrays = new Class1();

        [TestCase(new[] { 1, 2, 6 }, true)]
        [TestCase(new[] { 6, 1, 2, 3 }, true)]
        [TestCase(new[] { 13, 6, 1, 2, 3 }, false)]

       
        public void Test1(int[] nums, bool expected)
        {
            var actual = _arrays.FirstLast6(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
