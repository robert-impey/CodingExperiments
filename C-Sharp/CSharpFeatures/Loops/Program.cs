using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exploring the uses of Loops.");

            for (var i = 1; i <= 10; i++)
            {
                if (i > 1)
                {
                    Console.Write(" ");
                }
                Console.Write(i);
            }
            Console.WriteLine();

            var myArray = new [] { 1, 2, 3 };
            PrintIntArray(myArray);
            for (var i = 0; i < myArray.Length; i++)
            {
                myArray[i]++;
            }
            PrintIntArray(myArray);
            foreach (var i in myArray)
            {
                //i++; // Causes error.
            }
            PrintIntArray(myArray);
        }

        static void PrintIntArray(int[] theArray)
        {
            bool first = true;
            foreach (var i in theArray)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    Console.Write(" ");
                }
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
