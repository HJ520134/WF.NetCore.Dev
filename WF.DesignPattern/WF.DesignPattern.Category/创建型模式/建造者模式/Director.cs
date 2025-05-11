namespace WF.DesignPattern.Category.建造者模式;

public class Director
{
    /// <summary>
    /// 组装电脑
    /// </summary>
    /// <param name="builder"></param>
    public void Constract(Builder builder)
    {
        builder.BuilCPU();
        builder.MainBoard();
        builder.MainShowCard();
    }
}