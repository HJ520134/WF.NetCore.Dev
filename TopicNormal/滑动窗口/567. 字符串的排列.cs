using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicNormal.滑动窗口
{
    internal class _567
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var needDic = new Dictionary<char, int>();
            var charArray = s1.ToCharArray();
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
            var vaild = 0;
            while (right < s2.Count())
            {
                var cur = s2[right];
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
                while ((right - left) >= s1.Length)
                {
                    if (vaild == needDic.Count())
                    {
                        return true;
                    }

                    var leftChar = s2[left];
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

            return false;
        }
    }
}
