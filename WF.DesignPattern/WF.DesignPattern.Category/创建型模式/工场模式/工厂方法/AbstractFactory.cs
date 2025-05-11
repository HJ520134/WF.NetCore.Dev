using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.DesignPattern.Category.工场模式.简单工厂;

namespace WF.DesignPattern.Category.工场模式.抽象工厂
{
    public abstract class AbstractFactory
    {
        public abstract Coffee GetCoffee();
    }

    public class AmericaFactory : AbstractFactory
    {
        public override Coffee GetCoffee()
        {
            return new AmericanCoffee();
        }
    }

    public class LatterFactory : AbstractFactory
    {
        public override Coffee GetCoffee()
        {
            return new LatterCoffee();
        }
    }
}
