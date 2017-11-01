using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedMutableData
{
    class ParallelForEachSumCalculator : ISumCalculator
    {
        private int sum = 0;

        public int Calculate(IEnumerable<int> xs)
        {
            Parallel.ForEach(xs, x => sum += x);

            return sum;
        }
    }
}
