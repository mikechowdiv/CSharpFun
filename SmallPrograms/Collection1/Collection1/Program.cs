using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    class Program
    {
        static void Main(string[] args)
        {

            //---------------------ARRAY LISTS -------------------------
            #region ArrayList code

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            //Number of items in list
            Console.WriteLine("Count: {0}", aList.Count);

            //The capacity auto increases as items are added
            Console.WriteLine("Capacity {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();

            //Add an object array
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

            //Add 1 array list to another
            aList.AddRange(aList2);

            //sort the list if the types are the same
            aList2.Sort();
            aList2.Reverse();

            //insert at the 2nd position
            aList2.Insert(1, "Turkey");

            //get the 1st 2 items
            ArrayList range = aList2.GetRange(0, 2);

            Console.WriteLine("TurkeyIndex: {0}", aList2.IndexOf("Turkey", 0));

           foreach(object o in range)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("--------------------------------------------");

            //convert an ArrayList into a string array
            string[] myArray = (string[])aList2.ToArray(typeof(string));

            //convert a string array into an ArrayList
            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);

            foreach(string s in custArrayList)
            {
                Console.WriteLine(s);
            }

            #endregion


            //---------------------------DICTIONARIES----------------------------

            #region Dictionary Code

            Console.WriteLine("----------------------------------------------------------");

            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");

            //remove a key / value
            superheroes.Remove("Barry West");

            //remove a keys
            Console.WriteLine("Count : {0}", superheroes.ContainsKey("Clark Kent"));

            //get the value for the key and store it in a string
            superheroes.TryGetValue("Clark Kent", out string test);
            Console.WriteLine($"Clark Kent : {test}");

            //cycle thru key value pairs
            foreach(KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

#endregion

            Console.ReadLine();
        }
    }
}
