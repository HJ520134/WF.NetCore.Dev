namespace WF.DesignPattern.Category.适配器模式;

public abstract class TwoHole
{
    public void SpecialRequest()
    {
        Console.WriteLine("我是一个两个空的插头");
    }
}

public interface  IThreeHole
{
    void Request();
}


public  class TwoHole2
{
    public void SpecialRequest()
    {
        Console.WriteLine("我是一个两个空的插头");
    }
}