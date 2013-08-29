using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairCount.Lib
{
    public class PairCounter
    {
        public static int Count(int k, int[] a)
        {
            var elementCounts = new Dictionary<int, int>();

            var groups = from element in a
                         group element by element;

            foreach (var group in groups)
            {
                elementCounts[group.Key] = group.Count();
            }

            var pairs = 0;
            foreach (var element in elementCounts.Keys)
            {
                var difference = k - element;

                if (elementCounts.ContainsKey(difference))
                {
                    pairs += elementCounts[element] * elementCounts[difference];
                }
            }

            return pairs;
        }
    }
}
