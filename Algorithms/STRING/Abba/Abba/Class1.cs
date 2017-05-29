using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Abba
{
    /*
     * Given two strings, a and b, return the result of putting them together in the order abba, e.g. "Hi" and "Bye" returns "HiByeByeHi". 

Abba("Hi", "Bye") -> "HiByeByeHi"
Abba("Yo", "Alice") -> "YoAliceAliceYo"
Abba("What", "Up") -> "WhatUpUpWhat"
     */
    public class Class1
    {
        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }
    }
    [TestFixture]
    public class Test
    {
        private Class1 _strings = new Class1();

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expected)
        {
            var actual = _strings.Abba(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
