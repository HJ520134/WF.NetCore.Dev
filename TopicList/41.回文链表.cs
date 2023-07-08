using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 回文链表
    {
        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            fast = head;
            var hight = ReVerseBack(slow);
            while (hight != null && hight.Val != fast.Val)
            {
                hight = hight.next;
                fast = fast.next;
            }

            return hight == null ? true : false;
        }

        public ListNode ReVerseBack(ListNode Head)
        {
            ListNode pre = null;
            ListNode cur = Head;
            while (cur != null)
            {
                ListNode temp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = temp;
            }
            return pre;
        }
    }
}