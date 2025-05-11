namespace WenFanLeetCode.TopicList;

/// <summary>
/// 实现思路是Hash表+双向链表
/// </summary>
public class LRUCache
{
    private int _capacity;
    private Dictionary<int, DLinkedNode> cache;
    private DLinkedNode head, tail;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        cache = new Dictionary<int, DLinkedNode>();
        head = new DLinkedNode();
        tail = new DLinkedNode();
        head.next = tail;
        tail.prev = head;
    }

    public int Get(int key)
    {
        if (cache.ContainsKey(key))
        {
            //移动到表头
            MoveToHead(cache[key]);
            return cache[key].value;
        }
        else
        {
            return -1;
        }
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            //移动到表头
            MoveToHead(cache[key]);
            cache[key].value = value;
        }
        else
        {
            if (cache.Count >= _capacity)
            {
                //移除表尾的节点
                RemoveTail();
            }

            //添加到表头
            AddToHead(new DLinkedNode(key, value));
        }
    }

    /// <summary>
    /// 移动到表头
    /// </summary>
    /// <param name="node"></param>
    public void MoveToHead(DLinkedNode node)
    {
        //先删除当前节点
        node.prev.next = node.next;
        node.next.prev = node.prev;
        //移动到表头后面
        node.prev = head;
        node.next = head.next;
        head.next.prev = node;
        head.next = node;
    }

    /// <summary>
    /// 添加到表头后面
    /// </summary>
    /// <param name="node"></param>
    public void AddToHead(DLinkedNode node)
    {
        //移动到链表头部
        node.prev = head;
        node.next = head.next;
        head.next.prev = node;
        head.next = node;
        //添加到缓存
        cache.Add(node.key, node);
    }

    /// <summary>
    /// 移除表尾的节点()
    /// </summary>
    /// <param name="node"></param>
    public void RemoveTail()
    {
        var node = tail.prev;
        node.prev.next = tail;
        tail.prev = node.prev;
        cache.Remove(node.key);
    }
}

/// <summary>
/// 定义一个点双向链表
/// </summary>
public class DLinkedNode
{
    public int key;
    public int value;
    public DLinkedNode prev;
    public DLinkedNode next;

    public DLinkedNode()
    {
    }

    public DLinkedNode(int key, int value)
    {
        this.key = key;
        this.value = value;
    }
}