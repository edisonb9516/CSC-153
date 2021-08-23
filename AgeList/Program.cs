using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeList
{
    class Program
    {
        /**
        * 2/9/2020
        * CSC 153
        * Brandon Edison   
        *This program is going to ask the user to run the program, ask for the amount of ages they will want to enter, and it will display the ages.
*/
        static void Main(string[] args)
        {
            string choice;
           
            Console.WriteLine("Press 1 to run age program and press 2 to exit program: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("How many ages are you entering today? ");
                int ages = int.Parse(Console.ReadLine());


                int[] allAges = new int[ages];

                for (int index = 0; index < allAges.Length; index++)

                {
                    int number;

                    Console.WriteLine("Enter the age: ");
                    number = int.Parse(Console.ReadLine());

                    allAges[index] = number;
                
                }
                


            }

            else if (choice == "2")
                Console.WriteLine("Goodbye");

            else
                Console.WriteLine("Incorrect input!");
            
            
            Console.ReadLine();




        }
    }
}
