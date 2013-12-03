using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Finds the count of pairs of elements in a
 * that have a sum equal to k.
 */
namespace PairCount.Lib
{
    public class PairCounter
    {
        public static int Count(int k, int[] a)
        {
            return Count(k, a, (kParam, aParam) => kParam - aParam);
        }

        /// <summary>
        /// Generic version of the counting function.
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="A"></typeparam>
        /// <param name="k"></param>
        /// <param name="a"></param>
        /// <param name="inverse">The inverse of the function that maps (ai, aj) to K.</param>
        /// <returns></returns>
        public static int Count<K, A>(K k, A[] a, Func<K, A, A> inverse)
        {
            var elementCounts = new Dictionary<A, int>();

            var groups = from element in a
                         group element by element;

            foreach (var group in groups)
            {
                elementCounts[group.Key] = group.Count();
            }

            var pairs = 0;
            foreach (var element in elementCounts.Keys)
            {
                var difference = inverse(k, element);

                if (elementCounts.ContainsKey(difference))
                {
                    pairs += elementCounts[element] * elementCounts[difference];
                }
            }

            return pairs;
        }
    }
}
