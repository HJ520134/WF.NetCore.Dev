using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 在排序数组中查找元素的第一个和最后一个位置
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return new int[] { -1, -1 };
            }
            //1.寻找左边开始的位置
            var left = 0;
            var right = nums.Length - 1;
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (target <= nums[mid])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (nums[right] != target)
            {
                return new int[] { -1, -1 };
            }

            var leftIndex = right;
            left = 0;
            right = nums.Length - 1;
            //2.寻找右边结束的位置
            while (left < right)
            {
                var mid = (left + right + 1) / 2;
                if (target >= nums[mid])
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return new int[] { leftIndex, right };
        }
    }
}