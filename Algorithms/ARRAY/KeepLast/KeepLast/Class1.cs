using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KeepLast
{
    /*
     * Given an int array, return a new array with double the length where its last element is the same as the original array, 
     * and all the other elements are 0. The original array will be length 1 or more. Note: by default, a new int array contains all 0's. 

KeepLast({4, 5, 6}) -> {0, 0, 0, 0, 0, 6}
KeepLast({1, 2}) -> {0, 0, 0, 2}
KeepLast({3}) -> {0, 3}
     */
    public class Class1
    {
        public int[] KeepLast(int[] num)
        {
            int[] result = new int[num.Length * 2];
            result[result.Length - 1] = num[num.Length - 1];
            return result;
        }
    }

    [TestFixture]
    public class Test
    {
        private Class1 _arrays = new Class1();

        [TestCase(new[] { 4, 5, 6 }, new[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new[] { 1, 2 }, new[] { 0, 0, 0, 2 })]
        [TestCase(new[] { 3 }, new[] { 0, 3 })]
        public void KeepLastTest(int[] nums, int[] expected)
        {
            var actual = _arrays.KeepLast(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
