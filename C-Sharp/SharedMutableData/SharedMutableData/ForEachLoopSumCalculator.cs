using System.Collections.Generic;

namespace SharedMutableData
{
    internal class ForEachLoopSumCalculator : ISumCalculator
    {
        public int Calculate(IEnumerable<int> xs)
        {
            var sum = 0;

            foreach(var x in xs)
            {
                sum += x;
            }

            return sum;
        }
    }
}
