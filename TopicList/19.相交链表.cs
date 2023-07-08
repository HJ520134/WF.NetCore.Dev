using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 相交链表
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode a = headA;
            ListNode b = headB;
            while (a != b)
            {
                a = a != null ? a.next : headB;
                b = b != null ? b.next : headA;
            }

            return a;
        }
    }
}