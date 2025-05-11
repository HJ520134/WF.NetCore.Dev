namespace WF.DesignPattern.Category.建造者模式;

public class Computer
{
    private List<string> PartList = new List<string>();

    public void Add(string partName)
    {
        PartList.Add($"电脑部件：{partName}");
    }

    public void Show()
    {
        foreach (var part in PartList)
        {
            Console.WriteLine($"显示部件：{part}");
        }
    }

}