using WF.DesignPattern.Category.建造者模式;

namespace WF.DesignPattern.UTest.建造者模式;

public class BuildPattenUTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BuilderTest()
    {
        var direct = new Director();
        var builderOne = new BuilderOne();
        var builderTwo = new BuilderTwo();
        direct.Constract(builderOne);
        var computerA = builderOne.GetComputer();
        computerA.Show();

        direct.Constract(builderTwo);
        var computerB = builderOne.GetComputer();
        computerB.Show();
    }
}