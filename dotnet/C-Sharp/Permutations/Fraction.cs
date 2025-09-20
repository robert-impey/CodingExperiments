namespace Permutations;

internal readonly struct Fraction(int matching, int total)
{
    public int Matching { get; } = matching;
    public int Total { get; } = total;
}