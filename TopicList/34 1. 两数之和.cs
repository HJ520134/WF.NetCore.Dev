using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 两数之和
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (nums[i] * 2 == target)
                    {
                        return new int[] { i, dic[nums[i]] };
                    }
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                //重复情况已经在上面返回了
                if (dic.ContainsKey(target - nums[i]) && dic[target - nums[i]] != i)
                {
                    return new int[] { i, dic[target - nums[i]] };
                }
            }

            return new int[] { 0, 0 };
        }


        public int[] TwoSum2(int[] nums, int target)
        {
            var res = TwoSumTarget(nums.ToList(), target).FirstOrDefault();
            return res.ToArray();
            ;
        }
        public List<List<int>> TwoSumTarget(List<int> nums, int target)
        {
            // nums 数组必须有序
            nums.Sort();
            int lo = 0, hi = nums.Count - 1;
            List<List<int>> res = new List<List<int>>();
            while (lo < hi)
            {
                int sum = nums[lo] + nums[hi];
                int left = nums[lo], right = nums[hi];
                int leftIndex = lo, rightIndex = hi;
                if (sum < target)
                {
                    while (lo < hi && nums[lo] == left) lo++;
                }
                else if (sum > target)
                {
                    while (lo < hi && nums[hi] == right) hi--;
                }
                else
                {
                    res.Add(new List<int> { leftIndex, rightIndex });
                    while (lo < hi && nums[lo] == left) lo++;
                    while (lo < hi && nums[hi] == right) hi--;
                }
            }
            return res;
        }
    }
}