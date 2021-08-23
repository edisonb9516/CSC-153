using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 2/23/20
* CSC 153
* Brandon Edison
* This program will allow the user to calculate the cost of a whole sale and the percentage
*/

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            //initialize the variable
            double cost;
            double percent;
            double total;

            //Ask the user for the whole sale price and put it into the variable
            Console.WriteLine("Please Enter the items whole sale cost: ");
            cost = double.Parse(Console.ReadLine());

            //Ask the user for the percent and put it into the variable
            Console.WriteLine("Please Enter the percentage markup (In decimal form): ");
            percent = double.Parse(Console.ReadLine());

            //Multiply the percent to get the right calculation and then get the cost 
            percent = percent * 10;
            total = cost + (percent * cost);

            // Display the total 
            Console.WriteLine("Your total is $" + total);

            Console.ReadLine();
        }
    }
}
