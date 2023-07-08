using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 环形链表II
    {
        public ListNode DetectCycle(ListNode head)
        {
            var fast = head; var slow = head;
            //第一次相遇
            while (true)
            {
                //没有环 不会相遇
                if (fast == null || fast.next == null)
                {
                    return null;
                }

                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    break;
                }
            }

            //第二次相遇
            fast = head;
            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;
            }

            return fast;
        }
    }
}