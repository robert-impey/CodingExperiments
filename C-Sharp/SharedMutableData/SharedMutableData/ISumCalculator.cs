using System.Collections.Generic;

namespace SharedMutableData
{
    internal interface ISumCalculator
    {
        int Calculate(IEnumerable<int> xs);
    }
}
