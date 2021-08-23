using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2HW1_edisonb9516
{
    static class Program
    {
/**
* 2/9/2020
* CSC 153
* Brandon Edison
* This program will have an array and display numbers in the array
*/
        static void Main()
        {
            const int SIZE = 7;
            string[] numbers = new string[SIZE];

            numbers[0]="1245.67";
            numbers[1] = "1189.55";
            numbers[2] = "1098.72";
            numbers[3] = "1456.88";
            numbers[4] = "2109.34";
            numbers[5] = "1987.55";
            numbers[6] = "1872.36";

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[6]);

            Console.ReadLine();




        }
    }
}
