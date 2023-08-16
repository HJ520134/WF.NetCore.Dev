using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 最长回文子串
    {
        public string LongestPalindrome(string s)
        {
            var res = string.Empty;
            var max = 0;
            var s_length = s.Length;
            for (int i = 0; i < s_length; i++)
            {
                for (int j = i + 1; j <= s_length; j++)
                {
                    if ((j - i) < max)
                    {
                        continue;
                    }

                    var subStr = s.Substring(i, j - i);
                    if (IsPalindromic(subStr) && subStr.Length > max)
                    {
                        res = s.Substring(i, j - i);
                        max = Math.Max(max, res.Length);
                    }
                }
            }

            return res;
        }

        public bool IsPalindromic(string subString)
        {
            var subCount = subString.Length;
            var subStrArray = subString.ToCharArray();
            for (int i = 0; i < subCount / 2; i++)
            {
                if (subString[i] != subStrArray[subCount - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}