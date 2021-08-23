using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Input
    {
        public static double GetInput(Double cost, Double percent)
        {
            
            Console.WriteLine("Please Enter the items whole sale cost: ");
            cost = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the percentage markup (In decimal form): ");
            percent = double.Parse(Console.ReadLine());

            return CalculateRetail(cost, percent);

        }
        public static double CalculateRetail(Double cost, Double percent)
        {

            double total = cost * percent
            return total;

        }

    }
}
