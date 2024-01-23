using WF.DesignPattern.Category.适配器模式;

namespace WF.DesignPattern.UTest.适配器模式;

public class AdapterPattenUTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AdapterPattenTest()
    {
        IThreeHole threeHole = new PowerAdapter();
        threeHole.Request();
        Console.ReadKey();
    }
    
    
    [Test]
    public void AdapterPatten2Test()
    {
        IThreeHole threeHole = new PowerAdapter2();
        threeHole.Request();
        Console.ReadKey();
    }
}