namespace LeetCode;

public class FindMaxStudentsOnBench
{
    public int MaxStudentsOnBench(int[][] students)
    {
        var maxStudentsOnBench = 0;

        var benches = new Dictionary<int, HashSet<int>>();

        for (var i = 0; i < students.Length; i++)
        {
            if (2 == students[i].Length)
            {
                var studentId = students[i][0];
                var benchId = students[i][1];

                if (!benches.ContainsKey(benchId))
                {
                    benches[benchId] = new HashSet<int>();
                }

                benches[benchId].Add(studentId);
            }
        }

        foreach (var bench in benches.Values)
        {
            var benchCount = bench.Count();
            if (benchCount > maxStudentsOnBench)
            {
                maxStudentsOnBench = benchCount;
            }
        }

        return maxStudentsOnBench;
    }
}
