using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StandardMessage
    {
        public static void Greeting()
        {
            //display the greeting
            Console.WriteLine("Welcome to the height calculator!");
        }
        public static void EnterTime()
        {
            //Ask the question for the user
            Console.WriteLine("Enter the time the object has fallen (in seconds)");
            Console.Write("->");
        }
        public static void DisplayTotal(ref double h)
        {
            //Display the message and the total afterwards
            Console.WriteLine("The height is " + h);
        }
    }
}
