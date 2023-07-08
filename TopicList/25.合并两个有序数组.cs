using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 合并两个有序数组
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var p1 = m - 1;
            var p2 = n - 1;
            var tail = m + n - 1;
            int cur;
            while (p1 >= 0 || p2 >= 0)
            {
                if (p1 == -1)
                {
                    cur = nums2[p2--];
                }
                else if (p2 == -1)
                {
                    cur = nums1[p1--];
                }
                else if (nums1[p1] > nums2[p2])
                {
                    cur = nums1[p1--];
                }
                else
                {
                    cur = nums2[p2--];
                }
                nums1[tail--] = cur;
            }
        }
    }
}