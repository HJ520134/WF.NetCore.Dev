
using WF.DesignPattern.Category.工场模式.简单工厂;

namespace WF.DesignPattern.UTest.工厂模式;

public class SimpleFactoryUTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SingletonTest()
    {
        var coffee = CoffeeFactory.CreateCoffee(CoffeeType.AmericaCoffee);
        coffee.GetName();
        coffee = CoffeeFactory.CreateCoffee(CoffeeType.LatterCoffee);
        coffee.GetName();
        coffee.AddSuger();
    }

}