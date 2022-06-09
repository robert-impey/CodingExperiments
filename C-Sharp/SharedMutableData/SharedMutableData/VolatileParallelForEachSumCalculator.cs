using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedMutableData
{
    internal class VolatileParallelForEachSumCalculator : ISumCalculator
    {
        private volatile int _sum;

        public int Calculate(IEnumerable<int> xs)
        {
            Parallel.ForEach(xs, x => _sum += x);

            return _sum;
        }
    }
}
