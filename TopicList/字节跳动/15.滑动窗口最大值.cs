using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 滑动窗口最大值
    {
        /// <summary>
        /// 双向队列
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2)
            {
                return nums;
            }

            var res = new int[nums.Length - k + 1];
            var queue = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //当前队列中的值 大-小的顺序;
                while (queue.Count > 0 && nums[queue.Last.Value] <= nums[i])
                {
                    queue.RemoveLast();
                }

                queue.AddLast(i);

                //判断对接的最大值是不是在滑动窗口的范围
                if (queue.First.Value <= i - k)
                {
                    queue.RemoveFirst();
                }

                //i是0开始 i=k-1 的时候窗口行成了
                if (i >= k - 1)
                {
                    res[i - k + 1] = nums[queue.First.Value];
                }
            }

            return res;
        }
    }
}