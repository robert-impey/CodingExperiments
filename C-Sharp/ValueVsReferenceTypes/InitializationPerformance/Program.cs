using System;
using System.Diagnostics;
using ValueVsReferenceTypes;
using static System.Console;

namespace InitializationPerformance
{
    class Program
    {
        private const int Max = 10;

        private static Random randomNumberGenerator = new Random();

        static void Main(string[] args)
        {
            int iterations = 100000000;
            if (args.Length > 0)
            {
                if (int.TryParse(args[0], out iterations))
                {
                    throw new ArgumentException(nameof(args));
                }
            }
            TimeInitializations(iterations);
        }

        private static void TimeInitializations(int iterations)
        {
            WriteLine($"Iterations: {iterations}");

            TimeInts(iterations);
            TimeClasses(iterations);
            TimeStructs(iterations);

            WriteLine("----------");
        }

        private static void TimeInts(int iterations)
        {
            WriteLine("Using ints ...");

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            for (int i = 0; i < iterations; i++)
            {
                int next = randomNumberGenerator.Next(Max);
            }

            stopWatch.Stop();

            WriteLine($"Time: {stopWatch.ElapsedMilliseconds} ms"); ;
        }

        private static void TimeClasses(int iterations)
        {
            WriteLine("Using classes ...");

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            for (int i = 0; i < iterations; i++)
            {
                MyClass myClass = new MyClass { MyInt = randomNumberGenerator.Next(Max) };
            }

            stopWatch.Stop();

            WriteLine($"Time: {stopWatch.ElapsedMilliseconds} ms"); ;
        }

        private static void TimeStructs(int iterations)
        {
            WriteLine("Using structs ...");

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            for (int i = 0; i < iterations; i++)
            {
                MyStruct myStruct = new MyStruct { MyInt = randomNumberGenerator.Next(Max) };
            }

            stopWatch.Stop();

            WriteLine($"Time: {stopWatch.ElapsedMilliseconds} ms"); ;
        }
    }
}