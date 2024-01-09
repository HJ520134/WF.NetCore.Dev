using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{

    /// <summary>
    /// 双指针
    /// </summary>
    public class 寻找重复数
    {
        /// <summary>
        /// 快慢指针
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindDuplicate(int[] nums)
        {
            var fast = 0; var slow = 0;
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);
            fast = 0;

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;
        }
    }
}