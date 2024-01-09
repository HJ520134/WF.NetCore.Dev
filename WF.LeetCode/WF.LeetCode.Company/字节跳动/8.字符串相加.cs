using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    /// 题解 双指针
    /// </summary>
    public class 字符串相加
    {
        public string AddStrings(string num1, string num2)
        {
            if (string.IsNullOrEmpty(num1) && string.IsNullOrEmpty(num2))
            {
                return "0";
            }

            var num1_Index = num1.Length - 1;
            var num2_Index = num2.Length - 1;
            var carry = 0;
            var res = new StringBuilder();
            while (num1_Index > 0 || num2_Index > 0)
            {
                var n1 = num1_Index > 0 ? num1[num1_Index] - '0' : 0;
                var n2 = num2_Index > 0 ? num2[num2_Index] - '0' : 0;
                var temp = n1 + n2 + carry;
                carry = temp / 10;
                res.Append(temp % 10);
                num1_Index--;
                num2_Index--;
            }

            if (carry == 1) { res.Append(1); }
            return Convert.ToString(res.ToString().Reverse());
        }
    }
}