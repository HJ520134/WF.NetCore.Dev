using WF.DesignPattern.Category.结构型模式.适配器模式;

namespace WF.DesignPattern.UTest._5适配器模式;

public class AdapterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AdapterPattenTest()
    {
        var target = new AdapterThreeHole();
        var adapter = new AdapterPattern(target);
        //两孔插头转成三孔插头
        adapter.AdpterTwoHole();
        //三孔插头转成两孔插头
        var target2 = new AdapterTwoHole();
        var adapter2 = new AdapterPattern(target);
        adapter.AdpterThreeHole();
    }
}