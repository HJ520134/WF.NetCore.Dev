namespace WF.DesignPattern.Category.结构型模式.适配器模式;

public class AdapterPattern : IDataAdapter
{
    private readonly AdapterBase _adapter;
    
    public AdapterPattern(AdapterBase adapter)
    {
        _adapter = adapter;
    }

    public string AdpterTwoHole()
    {
        return  _adapter.HoleConvert();
    }

    public string AdpterThreeHole()
    {  return  _adapter.HoleConvert();
    }
}

