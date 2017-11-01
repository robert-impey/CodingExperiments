using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedMutableData
{
    class LockParallelForEachSumCalculator : ISumCalculator
    {
        private object lockObject = new object();
        private int sum = 0;

        public int Calculate(IEnumerable<int> xs)
        {
            Parallel.ForEach(xs, x => IncreaseSum(x));
            return sum;
        }

        private void IncreaseSum(int addend)
        {
            lock (lockObject)
            {
                sum += addend;
            }
        }
    }
}
