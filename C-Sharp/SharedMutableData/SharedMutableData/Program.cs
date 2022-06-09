using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static System.Console;

namespace SharedMutableData
{
    internal static class Program
    {
        private static void Main()
        {
            const int max = 10000;

            const int expected = ((max + 1) * max) / 2;

            var sumCalculators = new List<ISumCalculator>
            {
                new ForEachLoopSumCalculator(),
                new ParallelForEachSumCalculator(),
                new LockParallelForEachSumCalculator(),
                new VolatileParallelForEachSumCalculator(),
                new InterlockedParallelForLoopCalculator()
            };

            var stopWatch = new Stopwatch();

            foreach (var sumCalculator in sumCalculators)
            {
                stopWatch.Reset();

                stopWatch.Start();
                var sum = sumCalculator.Calculate(Enumerable.Range(1, max));
                stopWatch.Stop();

                Write(sumCalculator.GetType().Name);
                Write(" - ");

                Write(sum);
                Write(" - ");

                Write(sum == expected);
                Write(" - ");

                Write(stopWatch.ElapsedTicks + " ticks");

                WriteLine();
            }
        }
    }
}
