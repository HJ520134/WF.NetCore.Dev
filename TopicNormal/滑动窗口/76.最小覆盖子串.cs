using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicNormal.滑动窗口
{
    public class _76
    {
        public string MinWindow(string s, string t)
        {
            var needDic = new Dictionary<char, int>();
            var charArray = t.ToCharArray();
            foreach (var item in charArray)
            {
                if (!needDic.ContainsKey(item))
                {
                    needDic.Add(item, 1);
                }
                else
                {
                    needDic[item] = needDic[item] + 1;
                }
            }

            var windowDic = new Dictionary<char, int>();
            var left = 0; var right = 0;
            var start = 0;
            var len = int.MaxValue;
            var vaild = 0;
            while (right < s.Count())
            {
                var cur = s[right];
                right++;
                //扩大窗口
                if (needDic.ContainsKey(cur))
                {
                    if (!windowDic.ContainsKey(cur))
                    {
                        windowDic.Add(cur, 1);
                    }
                    else
                    {
                        windowDic[cur] += 1;
                    }

                    if (windowDic[cur].Equals(needDic[cur]))
                    {
                        vaild++;
                    }
                }

                //缩小窗口
                while (vaild == needDic.Count)
                {
                    if (right - left < len)
                    {
                        start = left;
                        len = right - left;
                    }

                    var leftChar = s[left];
                    left++;
                    if (needDic.ContainsKey(leftChar))
                    {
                        if (windowDic[leftChar].Equals(needDic[leftChar]))
                        {
                            vaild--;
                        }
                        windowDic[leftChar] -= 1;
                    }
                }
            }
     
        return len==int.MaxValue?"":s.Substring(start, len);
        }

    }
}
