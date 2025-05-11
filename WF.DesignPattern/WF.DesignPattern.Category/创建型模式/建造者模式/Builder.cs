namespace WF.DesignPattern.Category.建造者模式;

public abstract class Builder
{
    /// <summary>
    /// 组装CPU
    /// </summary>
    public abstract void BuilCPU();

    /// <summary>
    /// 组装主板
    /// </summary>
    public abstract void MainBoard();

    /// <summary>
    /// 组装显卡
    /// </summary>
    public abstract void MainShowCard();

    /// <summary>
    /// 获取电脑
    /// </summary>
    /// <returns></returns>
    public abstract Computer GetComputer();
}

public class BuilderOne : Builder
{
    readonly Computer computer = new Computer();

    public override void BuilCPU()
    {
        computer.Add("CPU-1");
    }

    public override void MainBoard()
    {
        computer.Add("MainBoard-1");
    }

    public override void MainShowCard()
    {
        computer.Add("ShowCard-1");
    }

    public override Computer GetComputer()
    {
        return computer;
    }
}

public class BuilderTwo : Builder
{
    readonly Computer computer = new Computer();

    public override void BuilCPU()
    {
        computer.Add("CPU-2");
    }

    public override void MainBoard()
    {
        computer.Add("MainBoard-2");
    }

    public override void MainShowCard()
    {
        computer.Add("ShowCard-2");
    }

    public override Computer GetComputer()
    {
        return computer;
    }
}