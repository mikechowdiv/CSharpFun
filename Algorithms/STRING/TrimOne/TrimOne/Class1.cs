using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TrimOne
{
    /*
     * Given a string, return a version without the first and last char, 
     * so "Hello" yields "ell". The string length will be at least 2. 

TrimOne("Hello") -> "ell"
TrimOne("java") -> "av"
TrimOne("coding") -> "odin"
     */

    public class Class1
    {
        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }
    }

    [TestFixture]
    public class Test
    {
        private Class1 _strings = new Class1();

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOneTest(string s, string expected)
        {
            var actual = _strings.TrimOne(s);
            Assert.AreEqual(expected, actual);
        }
    }

}
