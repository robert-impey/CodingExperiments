using System.Collections.Generic;

namespace SharedMutableData
{
    interface ISumCalculator
    {
        int Calculate(IEnumerable<int> xs);
    }
}
