using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.DesignPattern.Category.工场模式.简单工厂
{
    /// <summary>
    /// 定义Coffee产品
    /// </summary>
    public abstract class Coffee
    {
        public abstract string GetName();

        public void AddSuger()
        {
            Console.WriteLine("加糖");
        }
    }
}
