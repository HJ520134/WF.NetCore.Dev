
using WF.DesignPattern.Category.工场模式.抽象工厂;
using WF.DesignPattern.Category.工场模式.简单工厂;

namespace WF.DesignPattern.UTest.工厂模式;

public class AbstractFactoryUTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AbstractFactoryTest()
    {
        var americaFactory = new AmericaFactory();
        var coffee = americaFactory.GetCoffee();
        coffee.GetName();

        var latterFactory = new LatterFactory();
        coffee = latterFactory.GetCoffee();
        coffee.GetName();

        coffee.AddSuger();
    }

}