using NUnit.Framework;

namespace Unlucky1
{
    /*
     * We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. 
Return true if the given array contains an unlucky 1 in the first 2 or last 2 positions in the array. 

Unlucky1({1, 3, 4, 5}) -> true
Unlucky1({2, 1, 3, 4, 5}) -> true
Unlucky1({1, 1, 1}) -> false
     */
    public class Class1
    {
        public bool Unlucky1(int[] num)
        {
            if ((num[0] == 1 && num[1] == 3) ||
                    (num[1] == 1 && num[2] == 3) ||
                    (num[num.Length - 2] == 1 && num[num.Length - 1] == 3))
            {
                return true;
            }
            else return false;
        }
    }
    
    [TestFixture]
    public class Test
    {
        private Class1 _arrays = new Class1();

        [TestCase(new[] { 1, 3, 4, 5 }, true)]
        [TestCase(new[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new[] { 1, 1, 1 }, false)]
        public void Unlucky1Test(int[] nums, bool expected)
        {
            var actual = _arrays.Unlucky1(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
