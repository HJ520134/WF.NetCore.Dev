using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    /// 接雨水-暴力-备忘录
    /// </summary>
    public class JieYuShui
    {
        public int trap(int[] height)
        {
            var res = 0;
            if (height.Length < 2)
            {
                return 0;
            }
            var arrayCount = height.Length;
            var l_Max = new int[arrayCount];
            var r_Max = new int[arrayCount];
            l_Max[0] = height[0];
            r_Max[arrayCount - 1] = height[arrayCount - 1];

            //从左边开始-计算i右边的最大值
            for (int i = 1; i < arrayCount; i++)
            {
                l_Max[i] = Math.Max(l_Max[i - 1], height[i]);
            }

            //从右边开始-计算i左边的最大值
            for (int i = arrayCount - 2; i >= 0; i--)
            {
                r_Max[i] = Math.Max(r_Max[i + 1], height[i]);
            }

            //计算答案
            for (int i = 0; i < arrayCount; i++)
            {
                res += Math.Min(l_Max[i], r_Max[i]) - height[i];
            }

            return res;
        }
    }

}
