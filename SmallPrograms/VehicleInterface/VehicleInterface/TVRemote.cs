using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInterface
{
    class TVRemote
    {
        //now we are modelling the action of picking up the remote with our hand
        public static IElectronicDevice GetDevice()
        {
            return new TV();
        }
    }
}
