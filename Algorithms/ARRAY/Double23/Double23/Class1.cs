using NUnit.Framework;

namespace Double23
{
    /*
     * Given an int array, return true if the array contains 2 twice, or 3 twice. 

Double23({2, 2, 3}) -> true
Double23({3, 4, 5, 3}) -> true
Double23({2, 3, 2, 2}) -> false
     */
    public class Class1
    {
        public bool Double23(int[] num)
        {
            int twoCount = 0;
            int threeCount = 0;
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] == 2) twoCount++;
                else if (num[i] == 3) threeCount++;
            }
            return (twoCount == 2 || threeCount == 2);
        }
    }

    [TestFixture]
    public class Test
    {
        private Class1 _arrays = new Class1();

        [TestCase(new[] { 2, 2, 3 }, true)]
        [TestCase(new[] { 3, 4, 5, 3 }, true)]
        [TestCase(new[] { 2, 3, 2, 2 }, false)]
        public void Double23Test(int[] nums, bool expected)
        {
            var actual = _arrays.Double23(nums);
            Assert.AreEqual(expected, actual);
        }
    }

}
