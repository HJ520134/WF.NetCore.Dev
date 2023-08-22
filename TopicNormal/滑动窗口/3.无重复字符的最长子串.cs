using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicNormal.滑动窗口
{
    internal class _3
    {
        public int LengthOfLongestSubstring(string s)
        {
            var left = 0; var right = 0;
            var len = s.Length;
            var result = new Dictionary<char, int>();
            var maxlen = 0;
            while (right < s.Length)
            {
                var hiChar = s[right];
                right++;
                if (result.ContainsKey(hiChar))
                {
                    result[hiChar] += 1;
                }
                else
                {
                    result.Add(hiChar, 1);
                }

                while (result[hiChar] > 1)
                {
                    var lowChar = s[left];
                    left++;
                    result[lowChar] -= 1;
                };
                maxlen = Math.Max(right - left, maxlen);
            }

            return maxlen;
        }
    }
}
