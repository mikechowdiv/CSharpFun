using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInterface
{
    class PowerButton : ICommand
    {
        //you can refer to inteances using the interface
        IElectronicDevice device;

        //now we get into the specifics of what happens when the power button is pressed
        public PowerButton(IElectronicDevice d1)
        {
            device = d1;
        }

        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
