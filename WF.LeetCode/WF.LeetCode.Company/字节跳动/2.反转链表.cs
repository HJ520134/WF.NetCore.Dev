namespace WenFanLeetCode.TopicList;

/// <summary>
/// 反转链表
/// </summary>
public class FanZhuanLianBiao
{
    public ListNode ReverseList(ListNode head)
    {
        var cur = head;
        ListNode pre = null;
        while (cur != null)
        {
            var temp = cur.next;//暂存下一个节点
            cur.next = pre;//修改Next 的指向
            pre = cur;//暂存前一个节点
            cur = temp;// cur 访问下一个节点
        }

        return pre;
    }
}

public class ListNode
{
    public ListNode(int val)
    {
        this.Val = val;
    }

    public int Val { get; set; }
    public ListNode next { get; set; }
}
