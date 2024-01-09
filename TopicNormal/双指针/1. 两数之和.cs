namespace WF.LeetCode.Category.双指针
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            Array.Sort(nums);
            var lo = 0; var hi = nums.Length - 1;
            while (lo < hi)
            {
                var sum = nums[lo] + nums[hi];
                if (target > sum)
                {
                    lo++;
                }
                else if (target < sum)
                {
                    hi--;
                }
                else
                {
                    return new int[] { lo, hi };
                }
            }

            return Array.Empty<int>();
        }
    }
}