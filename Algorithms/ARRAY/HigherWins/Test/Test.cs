using HigherWins;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Test
    {
        private Class1 arr = new Class1();

        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 3, 3 })]
        [TestCase(new[] { 11, 5, 9 }, new[] { 11, 11, 11 })]
        [TestCase(new[] { 2, 11, 3 }, new[] { 3, 3, 3 })]
        public void HigherWinsTest(int[] nums, int[] expected)
        {
            var actual = arr.HighWins(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
