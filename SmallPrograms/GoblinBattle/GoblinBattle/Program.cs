using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up first goblin
            string name1 = PromptForName();
            Goblin g1 = new Goblin()
            {
                Name = name1,
                HitPoints = 10,
                Weapon = PromptForWeapon(name1)
            };
            SummarizeAndWait(g1);

            //set up second goblin
            Console.Clear();
            string name2 = "";
            name2 = PromptForName(another: true);
            Goblin g2 = new Goblin()
            {
                Name = name2,
                HitPoints = 10,
                Weapon = PromptForWeapon(name2)
            };
            SummarizeAndWait(g2);

            FightManager fm = new FightManager();
            Console.WriteLine();
            fm.Fight(g1, g2);
        }

        private static void SummarizeAndWait(Goblin g1)
        {
            Console.WriteLine($"{g1.Name} has chosen {g1.Weapon}! Press any key to continue.");
            Console.ReadKey();
        }

        private static Weapon PromptForWeapon(string name1)
        {
            bool valid = false;
            int choice;
            int randomChoice = 0;
            do
            {
                Console.WriteLine($"Choose a weapon for {name1}");
                foreach (Weapon weapon in Enum.GetValues(typeof(Weapon)))
                {
                    Console.WriteLine($"{(int)weapon} : {weapon}");
                    randomChoice = ((int)weapon) + 1;
                }
                Console.WriteLine($"{randomChoice} : Random");
                Console.WriteLine("Enter your selection");
                valid = int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= 3;
                if (!valid)
                {
                    Console.WriteLine("Invalid selection!\n");
                }
            } while (!valid);

            if(choice == randomChoice)
            {
                Random _rng = new Random();
                choice = _rng.Next(0, choice);
            }
            return (Weapon)choice;
        }

        private static string PromptForName(bool another = false)
        {
            if (!another) Console.WriteLine("enter a goblin's name");
            else Console.WriteLine("enter another goblin's name");
            return Console.ReadLine().Trim();
        }
    }
}
