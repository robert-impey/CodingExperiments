using Sorting.Lib;
using Sorting.Lib.Algorithms;
using System;

namespace StressTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arraysSorted = 0;
            while (arraysSorted < int.MaxValue)
            {
                var randomArray = new int[1000];

                var random = new Random();

                for (var i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = random.Next(1000);
                }

                var sorted = new BubbleSorter().Sort(randomArray);
                arraysSorted++;

                if (!SortingChecker.IsInOrder(sorted))
                {
                    Console.WriteLine("Array not sorted correctly!");
                    break;
                }

                if (arraysSorted % 1000 == 0)
                {
                    Console.WriteLine($"{arraysSorted} Arrays Sorted");
                }
            }
        }
    }
}