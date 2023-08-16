using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class x的平方根
    {
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            var left = 0;
            var right = x / 2;

            while (left < right)
            {
                var mid = (left + right) / 2 + 1;
                if (mid > x / mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid;
                }
            }

            return left;
        }
    }
}