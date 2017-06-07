using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Models;

namespace Test
{
    [TestFixture]
   public class Test
    {
        [TestCase(10,5,5)]
        [TestCase(10,10,0)]
        public void TakeDamageTest(int hitPoints, int damage, int expected)
        {
            Goblin target = new Goblin(10);
            target.TakeDamage(damage);
            Assert.AreEqual(target.HitPoints, expected);
        }

        [Test]
        public void AttackDamage()
        {
            Goblin attacker = new Goblin(10);
            Goblin defender = new Goblin(10);

            attacker.Attack(defender);
            Assert.Less(defender.HitPoints, 10);
        }

        [TestCase(5,5,true)]
        [TestCase(100,5,true)]
        [TestCase(4,5,false)]
        [TestCase(0,5,false)]
        public void DeathTest(int damage, int hp, bool expected)
        {
            Goblin target = new Goblin(hp);
            target.TakeDamage(damage);
            Assert.AreEqual(target.IsDead, expected);
        }


    }
}
