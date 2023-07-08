using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class 每日温度
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var tsResult = new int[temperatures.Length];
            if (temperatures == null)
            {
                return tsResult;
            }

            var tsStack = new Stack<int>();

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (tsStack.Count > 0 && temperatures[i] > temperatures[tsStack.Peek()])
                {
                    var index = tsStack.Pop();
                    tsResult[index] = i - index;
                }
                tsStack.Push(i);
            }

            return tsResult;
        }
    }
}