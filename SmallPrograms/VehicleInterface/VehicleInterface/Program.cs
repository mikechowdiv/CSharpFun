using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Buick", 4, 160);

            if(v1 is IDrivable)
            {
                v1.Move();
                v1.Stop();
            }
            else
            {
                Console.WriteLine("the {0} can't be driven", v1.Brand);
            }

            //------------------------------------------------------------------------------

            //picking up the TV remote
            IElectronicDevice TV = TVRemote.GetDevice();

            //create the power button
            PowerButton pb = new PowerButton(TV);

            //turn the TV on and off with each press
            pb.Execute();
            pb.Undo();

            Console.ReadLine();
        }
    }
}
