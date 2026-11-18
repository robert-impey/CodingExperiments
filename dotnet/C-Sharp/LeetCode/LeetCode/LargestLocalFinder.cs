namespace LeetCode;

// https://leetcode.com/problems/largest-local-values-in-a-matrix/

public class LargestLocalFinder
{
    public int[][] LargestLocal(int[][] grid)
    {
        var innerLength = grid.Length - 2;
        int[][] maxLocal = new int[innerLength][];

        for (var i = 0; i < innerLength; i++)
        {
            maxLocal[i] = new int[innerLength];
            var gridI = i + 1;

            for (var j = 0; j < innerLength; j++)
            {
                var gridJ = j + 1;    

                // NW
                maxLocal[i][j] = grid[gridI - 1][gridJ - 1];

                // N
                var candidate = grid[gridI][gridJ - 1];
                if (candidate > maxLocal[i][j])
                {
                    maxLocal[i][j] = candidate;
                }

                // NE
                candidate = grid[gridI + 1][gridJ - 1];
                if (candidate > maxLocal[i][j])
                {
                    maxLocal[i][j] = candidate;
                }

                // W
                candidate = grid[gridI - 1][gridJ];
                if (candidate > maxLocal[i][j])
                {
                    maxLocal[i][j] = candidate;
                }

                // C
                candidate = grid[gridI][gridJ];
                if (candidate > maxLocal[i][j])
                {
                    maxLocal[i][j] = candidate;
                }

                // E
                candidate = grid[gridI + 1][gridJ];
                if (candidate > maxLocal[i][j])
                {
                    maxLocal[i][j] = candidate;
                }

                // SE
                candidate = grid[gridI - 1][gridJ + 1];
                if (candidate > maxLocal[i][j])
                {
                    maxLocal[i][j] = candidate;
                }

                // S
                candidate = grid[gridI][gridJ + 1];
                if (candidate > maxLocal[i][j])
                {
                    maxLocal[i][j] = candidate;
                }

                // SW
                candidate = grid[gridI + 1][gridJ + 1];
                if (candidate > maxLocal[i][j])
                {
                    maxLocal[i][j] = candidate;
                }
            }
        }

        return maxLocal;
    }
}
