using NUnit.Framework;
using TitleCase;

namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Example()
        {
            Execise ex = new Execise();

            var result = ex.Case("i love solving problems and it is fun");
            
            Assert.AreEqual("I Love Solving Problems and It Is Fun", result);
        }
    }
}
