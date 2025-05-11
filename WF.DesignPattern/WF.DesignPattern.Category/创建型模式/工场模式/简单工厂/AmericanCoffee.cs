using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.DesignPattern.Category.工场模式.简单工厂
{
    public class AmericanCoffee : Coffee
    {
        public override string GetName()
        {
            return $"美式咖啡";
        }
    }
}
