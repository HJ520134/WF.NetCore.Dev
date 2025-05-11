using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.DesignPattern.Category.工场模式.简单工厂
{
    public class CoffeeFactory
    {
        public static Coffee CreateCoffee(CoffeeType coffeeType)
        {

            switch (coffeeType)
            {
                case CoffeeType.AmericaCoffee:
                    return new AmericanCoffee();
                case CoffeeType.LatterCoffee:
                    return new LatterCoffee();
            }

            return null;
        }
    }
}
