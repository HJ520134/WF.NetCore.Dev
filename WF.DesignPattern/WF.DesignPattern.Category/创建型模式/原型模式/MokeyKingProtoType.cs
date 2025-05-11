namespace WF.DesignPattern.Category.原型模式;

/// <summary>
/// 悟空原型
/// </summary>
public abstract class MokeyKingProtoType
{
    public string Id { get; set; }

    public MokeyKingProtoType(string id)
    {
        this.Id = id;
    }

    public abstract MokeyKingProtoType Clone();
}