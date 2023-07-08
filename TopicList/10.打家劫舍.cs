using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    /// 198. 打家劫舍 动态规划+递归
    /// </summary>
    public class 打家劫舍
    {
        /// <summary>
        /// 备忘录-已经计算的就不再计算
        /// </summary>
        private int[] memo;

        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            memo = new int[nums.Length];
            Array.Fill(memo, -1);
            return Dp(nums, 0);
        }

        public int Dp(int[] nums, int start)
        {
            if (start >= nums.Length)
            {
                return 0;
            }

            if (memo[start] != -1)
            {
                return memo[start];
            }
            //Dp(nums, start + 1) 抢 当前的结果
            //Dp(nums, start + 2) + nums[start] 不抢  当前的结果
            int res = Math.Max(Dp(nums, start + 1), Dp(nums, start + 2) + nums[start]);
            memo[start] = res;
            return res;
        }
    }
}