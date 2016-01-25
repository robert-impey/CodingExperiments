using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static System.Console;

namespace ArrayAndListAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                int sizeOfSequence;
                if (int.TryParse(arg, out sizeOfSequence))
                {
                    WriteLine($"Experimenting with a sequence of {sizeOfSequence} numbers.");

                    TestArray(sizeOfSequence);
                    TestList(sizeOfSequence);
                    TestListElementAt(sizeOfSequence);
                    TestLinkedList(sizeOfSequence);
                }
            }
        }

        private static void TestArray(int sizeOfSequence)
        {
            WriteLine("Testing the array");

            var ary = new int[sizeOfSequence];

            for (var i = 0; i < sizeOfSequence; i++)
            {
                ary[i] = i;
            }

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var rand = new Random();

            for (var i = 0; i < sizeOfSequence; i++)
            {
                var index = rand.Next(sizeOfSequence);

                var ele = ary[index];
            }

            stopwatch.Stop();

            WriteLine($"Accessed in {stopwatch.ElapsedMilliseconds} ms.");
        }

        private static void TestList(int sizeOfSequence)
        {
            WriteLine("Testing the list");

            var list = new List<int>();

            for (var i = 0; i < sizeOfSequence; i++)
            {
                list.Add(i);
            }

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var rand = new Random();

            for (var i = 0; i < sizeOfSequence; i++)
            {
                var index = rand.Next(sizeOfSequence);

                var ele = list[index];
            }

            stopwatch.Stop();

            WriteLine($"Accessed in {stopwatch.ElapsedMilliseconds} ms.");
        }

        private static void TestListElementAt(int sizeOfSequence)
        {
            WriteLine("Testing the list with element at");

            var list = new List<int>();

            for (var i = 0; i < sizeOfSequence; i++)
            {
                list.Add(i);
            }

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var rand = new Random();

            for (var i = 0; i < sizeOfSequence; i++)
            {
                var index = rand.Next(sizeOfSequence);

                var ele = list.ElementAt(index);
            }

            stopwatch.Stop();

            WriteLine($"Accessed in {stopwatch.ElapsedMilliseconds} ms.");
        }

        private static void TestLinkedList(int sizeOfSequence)
        {
            WriteLine("Testing the linked list");

            var list = new LinkedList<int>();

            for (var i = 0; i < sizeOfSequence; i++)
            {
                list.AddLast(i);
            }

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var rand = new Random();

            for (var i = 0; i < sizeOfSequence; i++)
            {
                var index = rand.Next(sizeOfSequence);

                var ele = list.ElementAt(index);
            }

            stopwatch.Stop();

            WriteLine($"Accessed in {stopwatch.ElapsedMilliseconds} ms.");
        }
    }
}
