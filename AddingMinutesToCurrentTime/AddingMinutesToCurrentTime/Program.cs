using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingMinutesToCurrentTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input
            Console.Write("enter current time in HH:MM format: ");
            string currentTime = Console.ReadLine();

            Console.Write("enter the amount of minutes you want to add: ");
            int minitesToAdd = Convert.ToInt32(Console.ReadLine());

            string[] totalTime = currentTime.Split(':');
            int currentHour = Convert.ToInt32(totalTime[0]);
            int currentMinute = Convert.ToInt32(totalTime[1]);

            //calculate new time hours and minutes
            //get future minutes. % 60 accomodates for 60 minutes cycle
            int futureMinutes = (currentMinute + minitesToAdd) % 60;

            //integer portion of the division gives us whole hour, then add them to current hours
            //use % for 24 hour day cycle
            int futureHour = ((currentMinute + minitesToAdd) / 60 + currentHour) % 24;

            //output new time formatted to HH:MM
            Console.WriteLine("New Time us {0}:{1}", futureHour.ToString("D2"), futureMinutes.ToString("D2"));
        }
    }
}
