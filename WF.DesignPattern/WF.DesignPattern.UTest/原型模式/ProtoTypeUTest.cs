using WF.DesignPattern.Category.原型模式;

namespace WF.DesignPattern.UTest.原型模式;

public class ProtoTypePattenUTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ProtoTypeTest()
    {
        MokeyKingProtoType mokeyKingProtoType = new ConcretePrototype("MonkeyIng");
        var mokeyKing1 = mokeyKingProtoType.Clone();
        Console.WriteLine($"mokeyKing1-{mokeyKing1.Id}");
        var mokeyKing2 = mokeyKingProtoType.Clone();
        Console.WriteLine($"mokeyKing2-{mokeyKing2.Id}");
    }
   

    
}