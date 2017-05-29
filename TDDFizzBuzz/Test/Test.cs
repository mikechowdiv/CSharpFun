using NUnit.Framework;
using TDDFizzBuzz;

namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Given5ExpectBuzz()
        {
            Class1 c = new Class1();
            var expected = "buzz";
            var actual = c.FB(5);
            Assert.AreEqual(expected, actual);
        }       
        [Test]
        public void Given15ExpectFizzBuzz()
        {
            Class1 c = new Class1();
            var expected = "fizzbuzz";
            var actual = c.FB(15);
            Assert.AreEqual(expected, actual);
        }
        

    }
}
