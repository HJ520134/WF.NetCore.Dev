using WF.LetCode.Common;
using WF.LetCode.Common.Model;

namespace WF.LeetCode.Category.双指针
{
    internal class _19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode(-1);
            dummy.next = head;
            var nNode = FindLastNNode(dummy, n + 1);
            nNode.next = nNode.next.next;
            return dummy.next;
        }

        /// <summary>
        /// 寻找倒数N个节点
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode FindLastNNode(ListNode head, int n)
        {
            var p1 = head;
            for (int i = 0; i < n; i++)
            {
                p1 = p1.next;
            }
            var p2 = head;
            while (p1 != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }
            return p2;
        }
    }
}
