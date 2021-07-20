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
