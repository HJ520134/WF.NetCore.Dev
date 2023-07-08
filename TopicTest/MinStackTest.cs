using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using WenFanLeetCode.TopicList;

namespace WenFanLeetCode.TopicTest
{
    public class MinStackTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            MinStack minStack = new MinStack();
            minStack.push(-2);
            minStack.push(0);
            minStack.push(-3);
            var min1 = minStack.GetMin(); // 返回 - 3.
            minStack.Pop();
            var top = minStack.Top(); //返回 0.
            var min = minStack.GetMin();// 返回 - 2.
        }

        [Test]
        public void Test2()
        {
            有效的括号 minStack = new 有效的括号();
            var s = "([}}])";
            minStack.IsValid(s);
        }


        [Test]
        public void Test3()
        {
            最长回文子串 minStack = new 最长回文子串();
            var str = "babad";
            minStack.LongestPalindrome(str);
        }

        [Test]
        public void DailyTemperatures()
        {
            var tsResult = new int[10];
            tsResult[0] = 1;
            每日温度 minStack = new 每日温度();
            var arr = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            minStack.DailyTemperatures(arr);
        }

    }
}