namespace Permutations
{
    struct Fraction
    {
        public int Matching { get; }
        public int Total { get; }

        public Fraction(int matching, int total)
        {
            Matching = matching;
            Total = total;
        }
    }
}
