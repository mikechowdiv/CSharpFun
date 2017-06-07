using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             [TestClass(10, 5, 5)]
        [TestClass(10, 10, 0)]
        public void TakeDamageTest(int hitPoints, int damage, int expected)
        {
            Goblin target = new Goblin(10);
            target.TakeDamage(damage);
            Assert.AreEqual(target.HitPoints, expected);
        }
    }
    }
}
