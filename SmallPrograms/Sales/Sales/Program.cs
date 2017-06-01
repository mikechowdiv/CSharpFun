﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    //program that accepts any number of monthly sales amounts.
    //display the amount in total of the values.
    //display a report showing each original value entered and the % th
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSales = 0;
            double[] sales;

            Console.Write("Please enter number of sales ");
            numberOfSales = Convert.ToInt32(Console.ReadLine());

            sales = new double[numberOfSales];

            for(int i = 0; i < numberOfSales; i++)
            {
                Console.Write("Please enter sale #{0}:", i + 1);
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = sales.Sum();
            for(int i = 0; i < numberOfSales; i++)
            {
                double contribution = sales[i] / sum;
                Console.WriteLine("Sale # {0} was {1:C2} and contributed {2:P2}", i+1,  sales[i], contribution);
            }

            Console.WriteLine("Total sum of sales is {0:C2}", sum);
        }
    }
}
