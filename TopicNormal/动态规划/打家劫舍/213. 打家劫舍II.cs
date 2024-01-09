
public class Solution
{
    private int[] memo;
    public int Rob(int[] nums)
    {
        var n = nums.Length;
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return nums[0];
        }

        memo = new int[nums.Length];
        Array.Fill(memo, -1);
        var result1 = RobRange(nums, 0, n - 2);
        Array.Fill(memo, -1);
        var result2 = RobRange(nums, 1, n - 1);
        return Math.Max(result1, result2);
    }

    public int RobRange(int[] nums, int start, int end)
    {
        if (start > end)
        {
            return 0;
        }

        if (memo[start] != -1)
        {
            return memo[start];
        }

        var res = Math.Max(RobRange(nums, start + 1, end), RobRange(nums, start + 2, end) + nums[start]);
        memo[start] = res;
        return res;
    }
}
