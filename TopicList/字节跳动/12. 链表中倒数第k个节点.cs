using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    /// 双指针
    /// </summary>
    public class 链表中倒数第k个节点
    {
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            //快指针
            var former = head;
            //慢指针
            var later = head;
            for (int i = 0; i < k; i++)
            {
                former = former.next;
            }

            while (former != null)
            {
                former = former.next;
                later = later.next;
            }

            return later;
        }
    }
}