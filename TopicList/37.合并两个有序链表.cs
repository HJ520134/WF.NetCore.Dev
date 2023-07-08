using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 合并两个有序链表
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var preHead = new ListNode(-1);
            var pre = preHead;
            while (list1 != null && list2 != null)
            {
                if (list1.Val <= list2.Val)
                {
                    pre.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    pre.next = list2;
                    list2 = list2.next;
                }
                pre = pre.next;
            }

            // 合并后 l1 和 l2 最多只有一个还未被合并完，我们直接将链表末尾指向未合并完的链表即可
            pre.next = list1 == null ? list2 : list1;
            return preHead.next;
        }
    }
}