using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    ///题解：辅助栈
    /// </summary>
    public class 有效的括号
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1)
            {
                return false;
            }

            var dic = new Dictionary<char, char>();
            dic.Add(')', '(');
            dic.Add(']', '[');
            dic.Add('}', '{');
            var s_Count = s.Length;
            var s_Stack = new Stack<char>();
            for (int i = 0; i < s_Count; i++)
            {
                if (s_Stack.Count == 0 || !dic.ContainsKey(s[i]))
                {
                    s_Stack.Push(s[i]);
                    continue;
                }

                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] == s_Stack.Peek())
                    {
                        s_Stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (s_Stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}