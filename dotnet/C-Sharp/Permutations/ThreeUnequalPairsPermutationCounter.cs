namespace Permutations
{
    /// <summary>
    /// How many 6-digit numbers are like 225599?
    /// That is XXYYZZ, three pairs of matching numbers where each pair does not match.
    /// </summary>
    internal class ThreeUnequalPairsPermutationCounter : ThreePairsPermutationCounter
    {
        protected override bool Test(int i, int j, int k)
        {
            return i != j && i != k && j != k;
        }
    }
}
