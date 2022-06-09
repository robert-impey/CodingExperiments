using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SharedMutableData
{
    internal class InterlockedParallelForLoopCalculator : ISumCalculator
    {
        private int _sum;

        public int Calculate(IEnumerable<int> xs)
        {
            Parallel.ForEach(xs, x => Interlocked.Add(ref _sum, x));

            return _sum;
        }
    }
}
