namespace LeetCode;

public class MissingElementsFinder
{
    public IList<int> FindMissingElements(int[] nums)
    {
        var missingElements = new List<int>();

        Array.Sort(nums);

        var min = nums[0];
        var max = nums[nums.Length - 1];

        for (var i = min + 1; i < max; i++)
        {
            if (!nums.Contains(i))
            {
                missingElements.Add(i);
            }
        }

        return missingElements;
    }
}
