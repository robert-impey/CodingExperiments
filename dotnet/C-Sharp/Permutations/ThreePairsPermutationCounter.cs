namespace Permutations
{
    class ThreePairsPermutationCounter : IPermutationCounter
    {
        public Fraction Count()
        {
            var totalCount = 0;
            var matchingCount = 0;
            for (var i = 0; i <= 9; i++)
            {
                for (var ii = 0; ii <= 9; ii++)
                {
                    for (var j = 0; j <= 9; j++)
                    {
                        for (var jj = 0; jj <= 9; jj++)
                        {
                            for (var k = 0; k <= 9; k++)
                            {
                                for (var kk = 0; kk <= 9; kk++)
                                {
                                    totalCount++;

                                    if (i == ii && j == jj && k == kk && Test(i, j, k))
                                    {
                                        matchingCount++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return new Fraction(matchingCount, totalCount);
        }

        protected virtual bool Test(int i, int j, int k)
        {
            return true;
        }
    }
}
