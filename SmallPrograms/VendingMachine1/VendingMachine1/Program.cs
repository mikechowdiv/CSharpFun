﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine1
{
    /*
     * Add a class to the application called “VendingMachine“.This class will be composed of one field (i.e., instance variable or attribute) and several methods as follows:

A field of type int called “DepositedAmount“

A constructor that takes no parameters that simply initializes the machine’s DepositedAmount to 0.

A method (no return value) called “DepositCoin” with a single int parameter called “coinAmount”.
This method adds the value passed in the coinAmount parameter to the machine’s DepositedAmount field.

A method (no return value) called “GetDrink” with no parameters
This method does one of two things. If the machine’s DepositedAmount is is sufficient to cover the cost of a drink (75 cents or more), then the method calculates the change 
(i.e.,DepositedAmount less 75 cents), writes “Your change is {change amount} cents” to the Console, and resets the DepositedAmount back to 0. 
If the machine’s DepositedAmount is not sufficient (less than 75 cents), it writes “Insert more coins” to the Console.

A method (no return value) called “GetRefund” with no parameters
This method simply displays “You were refunded {refund amount}” (refund amount should be the whole DepositedAmount) to the console and resets the machine’s DepositedAmountback to 0.
Your Main method should create a single instance of your VendingMachine class. You should then call methods on this object to fully test that the machine is functioning properly. 
No need to get input from the user. Just “hard code” instructions in your Main method.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine();
            vendingMachine.DepositCoin(50);
            vendingMachine.DepositCoin(44);
            vendingMachine.GetDrink();

            Console.ReadLine();
        }
    }
}
