namespace WF.DesignPattern.Category.结构型模式.适配器模式;

public class AdapterThreeHole:AdapterBase
{
    public override string HoleConvert()
    {
        return "三孔插头";
    }
}

public class AdapterTwoHole:AdapterBase
{
    public override string HoleConvert()
    {
        return "两孔插头";
    }
}


public abstract class AdapterBase
{
    public abstract string HoleConvert();
}



