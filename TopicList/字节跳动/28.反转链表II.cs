using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 反转链表II
    {
        ListNode lastNode = null;
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (left == 1)
            {
                return ReverseN(head, right);
            }

            head.next = ReverseBetween(head.next, left - 1, right - 1);
            return head;
        }

        public ListNode ReverseN(ListNode head, int n)
        {
            if (n == 1)
            {
                lastNode = head.next;
                return head;
            }

            var last = ReverseN(head.next, n - 1);
            head.next.next = head;
            head.next = lastNode;
            return last;
        }

    }
}