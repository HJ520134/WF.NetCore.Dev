using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 颠倒字符串中的单词
    {
        public string ReverseWords(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var s_Array = s.Split(' ');
            var resultSb = new StringBuilder();
            var stack = new Stack<string>();
            foreach (var item in s_Array)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    stack.Push(item);
                }
            }

            while (stack.Count >= 0)
            {
                resultSb.Append(stack.Pop());
                resultSb.Append(' ');
            }

            return resultSb.ToString().TrimEnd();
        }
    }
}