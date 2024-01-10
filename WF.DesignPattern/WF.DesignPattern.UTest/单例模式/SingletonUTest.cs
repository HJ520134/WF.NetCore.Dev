using WF.DesignPattern.Category.单例模式;

namespace WF.DesignPattern.UTest.单例模式;

public class SingletonUTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SingletonTest()
    {
        var firstSingleton = Singleton.Instance;
        firstSingleton.LogMessage("firstSingleton");

        var secondSingleton = Singleton.Instance;
        secondSingleton.LogMessage("secondSingleton");

        Console.ReadLine();
    }


    [Test]
    public void SingletonLazyTest()
    {
        var firstSingleton = SingletonLazy.Instance;
        var firstSingletonStr= firstSingleton.LogMessage("firstSingleton");

        var secondSingleton = SingletonLazy.Instance;
        var secondSingletonStr = secondSingleton.LogMessage("secondSingleton");

        Console.ReadLine();
    }

}