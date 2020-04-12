using System;
using CommandLine;
using Sorting.Lib;
using Sorting.Lib.Algorithms;

namespace Sorting
{
    internal class Program
    {
        public class Options
        {
            [Option('a', "algorithm", Required = true, HelpText = "The sorting algorithm to use.")]
            public string Algorith { get; set; }

            [Option('s', "size", Required = false, Default = 1000, HelpText = "The size of the array to sort.")]
            public int Size { get; set; }

            [Option('r', "range", Required = false, Default = 1000, HelpText = "The range of integers in the random array.")]
            public int Range { get; set; }

            [Option('n', "runs", Required = false, Default = int.MaxValue, HelpText = "The number of runs.")]
            public int Runs { get; set; }
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

                           case "top-down-list-merge":

                               sorter = new TopDownListMergeSorter();
                               break;

                           case "heap":

                               sorter = new HeapSorter();
                               break;

                           default:
                               Console.WriteLine($"Unrecognised sorter - {args[0]}!");
                               return;
                       }
                       StressTest(sorter, o.Size, o.Range, o.Runs);
                   });
        }

        private static void StressTest(IIntSorter sorter, int size, int range, int runs)
        {
            var arraysSorted = 0;
            while (arraysSorted < runs)
            {
                var randomArray = new int[size];

                var random = new Random();

                for (var i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = random.Next(range);
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