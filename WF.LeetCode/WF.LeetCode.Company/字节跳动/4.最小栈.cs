using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    /// 155. 最小栈 思路：辅助栈
    /// </summary>
    public class MinStack
    {
        Stack<int> stack_Min = new Stack<int>();
        Stack<int> stack_Cur = new Stack<int>();
        public void push(int val)
        {
            if (stack_Min.Count == 0 || stack_Min.Peek() > val)
            {
                stack_Min.Push(val);
            }
            stack_Cur.Push(val);
        }

        public void Pop()
        {
            if (stack_Cur.Peek() == stack_Min.Peek())
            {
                stack_Min.Pop();
            }
            stack_Cur.Pop();
        }

        public int Top()
        {
            return stack_Cur.Peek();
        }

        public int GetMin()
        {
            return stack_Min.Peek();
        }
    }
}