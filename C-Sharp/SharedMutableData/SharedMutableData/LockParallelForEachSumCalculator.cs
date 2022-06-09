using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedMutableData
{
    internal class LockParallelForEachSumCalculator : ISumCalculator
    {
        private readonly object _lockObject = new object();
        private int _sum;

        public int Calculate(IEnumerable<int> xs)
        {
            Parallel.ForEach(xs, IncreaseSum);
            return _sum;
        }

        private void IncreaseSum(int addend)
        {
            lock (_lockObject)
            {
                _sum += addend;
            }
        }
    }
}
