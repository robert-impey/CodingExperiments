using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SharedMutableData
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Max = 10000;

            var sumCalculators = new List<ISumCalculator>();

            sumCalculators.Add(new ForEachLoopSumCalculator());
            sumCalculators.Add(new ParallelForEachSumCalculator());
            sumCalculators.Add(new LockParallelForEachSumCalculator());
            sumCalculators.Add(new VolatileParallelForEachSumCalculator());

            var stopWatch = new Stopwatch();

            foreach (var sumCalculator in sumCalculators)
            {
                stopWatch.Reset();

                stopWatch.Start();
                var sum = sumCalculator.Calculate(Enumerable.Range(1, Max));
                stopWatch.Stop();

                Console.Write(sumCalculator.GetType().Name);
                Console.Write(" - ");
                Console.Write(sum);
                Console.Write(" - ");
                Console.Write(stopWatch.ElapsedTicks + " ticks");

                Console.WriteLine();
            }
        }
    }
}
