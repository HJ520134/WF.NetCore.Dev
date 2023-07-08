using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class K个一组翻转链表
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }
            ListNode a = head;
            ListNode b = head;

            for (int i = 0; i < k; i++)
            {
                if (b == null)
                {
                    return head;
                }
                b = b.next;
            }
            ListNode newHead = ReverseRange(a, b);
            a.next = ReverseKGroup(b, k);
            return newHead;
        }

        /// <summary>
        /// 反转范围内的链表
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public ListNode ReverseRange(ListNode a, ListNode b)
        {
            ListNode pre = null;
            ListNode cur = a;
            ListNode next = a;
            while (cur != b)
            {
                next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }
            return pre;
        }
    }
}