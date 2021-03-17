using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class ThreeAscendingPairsPermutationCounter : ThreePairsPermutationCounter
    {
        protected override bool Test(int i, int j, int k)
        {
            return i <= j && j <= k;
        }
    }
}
