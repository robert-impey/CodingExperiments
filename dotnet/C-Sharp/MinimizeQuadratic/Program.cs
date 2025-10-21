// 2025-10-21
// See ...\CodingExperiments\dotnet\F-Sharp\Loose\MinimiseQuadratic.fsx

namespace MinimizeQuadratic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var min = 0.0;
            var max = 10.0;
            var step = 0.001;

            var bestX = min;
            var bestCandidate = F(min);
            for (var x = min + step; x <= max; x += step)
            {
                var candidate = F(x);
                if (candidate < bestCandidate)
                {
                    bestX = x;
                    bestCandidate = candidate;
                }
            }

            Console.WriteLine($"Minimum value found at: ({bestX}, {bestCandidate})");
        }

        private static double F(double x) => (x * x) - (2.0 * x) + 1.0;
    }
}
