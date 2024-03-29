﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedMutableData
{
    internal class ParallelForEachSumCalculator : ISumCalculator
    {
        private int _sum;

        public int Calculate(IEnumerable<int> xs)
        {
            Parallel.ForEach(xs, x => _sum += x);

            return _sum;
        }
    }
}
