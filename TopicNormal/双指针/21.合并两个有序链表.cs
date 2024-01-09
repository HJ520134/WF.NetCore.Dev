using WF.LetCode.Common;
using WF.LetCode.Common.Model;

namespace WF.LeetCode.Category.双指针
{
    internal class _21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var preNode = new ListNode(-1);
            var head = new ListNode(-1);
            head = preNode;
            var p1 = list1;
            var p2 = list2;

            while (p1 != null && p2 != null)
            {
                if (p1.val > p2.val)
                {
                    head.next = p2;
                    p2 = p2.next;
                }
                else
                {
                    head.next = p1;
                    p1 = p1.next;
                }
                head = head.next;
            }

            if (p1 == null)
            {
                head.next = p2;
            }
            if (p2 == null)
            {
                head.next = p1;
            }

            return preNode.next;
        }
    }
}
