using NUnit.Framework;
using SameFirstLast;

namespace Test
{
    [TestFixture]
    public class Test
    {
        private Class1 _arr = new Class1();
        [TestCase(new[] { 1, 2, 3 }, false)]
        [TestCase(new[] { 1, 2, 3, 1 }, true)]
        [TestCase(new[] { 1, 2, 1 }, true)]

        public void SameFirstLastTest(int[] nums, bool expected)
        {
            var actual = _arr.SameFirstLast(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
