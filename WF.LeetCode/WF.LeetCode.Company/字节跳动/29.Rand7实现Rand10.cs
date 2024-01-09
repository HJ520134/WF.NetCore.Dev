using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    public class Rand7实现Rand10
    {
        public int Rand10()
        {
            int rand49;
            do
            {
                rand49 = (Rand7() - 1) * 7 + Rand7();

            } while (rand49 > 40);

            return rand49 % 10 + 1;
        }

        public int Rand7()
        {
            Random r = new Random();
            int num = r.Next(1, 8);
            return num;
        }
    }
}