using System.Security.AccessControl;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using System.ComponentModel;
using System.Collections;
using System.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopicNormal.动态规划.打家劫舍2
{
    public class Solution
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