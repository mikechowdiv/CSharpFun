using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Goblin
    {
        private static Random _rng = new Random();
        private readonly int maxHitPts;
        private int _hitPoints;
        public int HitPoints
        {
            get { return _hitPoints; }
            set { _hitPoints = (value < 0) ? 0 : (value > maxHitPts) ? maxHitPts : value; }
        }

        public string Name { get; set; }
        public bool IsDead { get; private set; }
        public Weapon Weapon { get; set; }
        public Goblin(int hitpoints = 10) : this(hitpoints, "Generic Goblin") { }
        public Goblin(int hitpoints, string name) : this(hitpoints, name, Weapon.Rock) { }
        public Goblin(int hitpoints, string name, Weapon weapon)
        {
            maxHitPts = hitpoints;
            HitPoints = maxHitPts;
            Name = name;
            IsDead = false;
            Weapon = weapon;
        }
        public void Attack(Goblin target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} using {Weapon} versus their {target.Weapon}.");
            int damage = CalculateDamage(this, target);
            target.TakeDamage(damage);
        }

        private int CalculateDamage(Goblin g1, Goblin g2)
        {
            int compare = (3 + g1.Weapon - g2.Weapon) % 3;
            if(compare == 1)
            {
                Console.WriteLine("It's super effective!");
                return _rng.Next(3, 6);
            }
            else if(compare == 2)
            {
                Console.WriteLine("It's not very effective");
                return _rng.Next(0, 3);
            }
            return _rng.Next(2, 4);
        }

        public void TakeDamage(int damage)
        {
            HitPoints -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. ");
            if(HitPoints > 0)
            {
                Console.WriteLine($"{Name} has {HitPoints} health left.");
            }
            else
            {
                IsDead = true;
                Console.WriteLine($"{Name} dies!");
            }
        }
    }
}
