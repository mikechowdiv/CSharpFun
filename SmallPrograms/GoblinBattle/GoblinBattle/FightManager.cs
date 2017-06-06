using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinBattle
{
  public  class FightManager
    {
        static Random r = new Random();

        public void Fight(Goblin g1, Goblin g2)
        {
            Console.Clear();
            Console.WriteLine($"{g1.Name} vs {g2.Name}");
            Console.WriteLine();

            Goblin active = null;
            Goblin passive = null;

            while (!g1.IsDead && !g2.IsDead)
            {
                if (active == null || passive == null)
                {
                    active = g1;
                    passive = g2;
                }
                else
                {
                    Goblin tmp = active;
                    active = passive;
                    passive = tmp;
                }
                active.Attack(passive);
                Console.WriteLine();
                System.Threading.Thread.Sleep(800);
            }
            Console.WriteLine($"The battle is ended! {active.Name} is victorious!\n(Press any key to continue");
            Console.ReadLine();
        }
    }
}
