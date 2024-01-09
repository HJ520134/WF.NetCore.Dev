namespace WF.LeetCode.Category.动态规划.打家劫舍
{
    public class 打家劫舍
    {
        private int[] memo;
        public int Rob(int[] nums)
        {
            memo = new int[nums.Length];
            Array.Fill(memo, -1);
            return dp(nums, 0);
        }

        public int dp(int[] nums, int start)
        {
            if (start >= nums.Length)
            {
                return 0;
            }

            if (memo[start] != -1)
            {
                return memo[start];
            }

            int res = Math.Max(dp(nums, start + 1), dp(nums, start + 2) + nums[start]);
            memo[start] = res;
            return res;
        }
    }
}