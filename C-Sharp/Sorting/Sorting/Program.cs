using CommandLine;
using Sorting.Lib;
using Sorting.Lib.Algorithms;
using System;

namespace StressTest
{
    internal class Program
    {
        public class Options
        {
            [Option('a', "algorithm", Required = true, HelpText = "The sorting algorithm to use.")]
            public string Algorith { get; set; }
        }

        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed(o =>
                   {
                       IIntSorter sorter;
                       switch (o.Algorith)
                       {
                           case "bubble":
                               sorter = new BubbleSorter();
                               break;

                           case "insertion":

                               sorter = new InsertionSorter();
                               break;

                           case "selection":

                               sorter = new SelectionSorter();
                               break;

                           case "gnome":

                               sorter = new GnomeSorter();
                               break;

                           default:
                               Console.WriteLine($"Unrecognised sorter - {args[0]}!");
                               return;
                       }
                       StressTest(sorter);
                   });
        }

        private static void StressTest(IIntSorter sorter)
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

                var sorted = sorter.Sort(randomArray);
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