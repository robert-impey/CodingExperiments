namespace LeetCode;

// https://leetcode.com/problems/restore-finishing-order/

public class RestoreFinishingOrder
{
    public int[] RecoverOrder(int[] order, int[] friends)
    {
        var recovered = new int[friends.Length];

        var counter = 0;

        for (var i = 0; i < order.Length; i++)
        {
            if (counter >= friends.Length)
            {
                break;
            }

            for (var j = 0; j < friends.Length; j++)
            {
                if (order[i] == friends[j])
                {
                    recovered[counter] = friends[j];
                    counter++;
                    break;
                }
            }
        }

        return recovered;
    }
}
