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
        var direact = new Director();
        var builderOne = new BuilderOne();
        var builderTwo = new BuilderTwo();
        direact.Constract(builderOne);
        var computerA = builderOne.GetComputer();
        computerA.Show();

        direact.Constract(builderTwo);
        var computerB = builderOne.GetComputer();
        computerB.Show();
    }
}