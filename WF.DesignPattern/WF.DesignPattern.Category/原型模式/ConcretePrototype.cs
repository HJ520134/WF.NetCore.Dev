namespace WF.DesignPattern.Category.原型模式;

public class ConcretePrototype:MokeyKingProtoType
{
    public ConcretePrototype(string id) : base(id)
    {
    }

    public override MokeyKingProtoType Clone()
    {
        return (MokeyKingProtoType)MemberwiseClone();
    }
}