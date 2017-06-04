using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine1
{
    class VendingMachine
    {
        private int depositAmount;
        const int drinkCost = 75;

        public VendingMachine()
        {
            depositAmount = 0;
        }

        public void DepositCoin(int coinAmount)
        {
            depositAmount += coinAmount;
        }

        public void GetDrink()
        {
            if(depositAmount >= 75)
            {
                Console.WriteLine("Your change is {0} cents", depositAmount - drinkCost);
                DepositCoin(0);
            }
            else
            {
                Console.WriteLine("Insert more coins");
            }
        }

        public void GetRefund()
        {
            Console.WriteLine("You were refunded {0}", depositAmount);
            DepositCoin(0);
        }
    }
}
