using System.Security.Cryptography.X509Certificates;

namespace WF.DesignPattern.Category.适配器模式;

public class PowerAdapter : TwoHole, IThreeHole
{
    public void Request()
    {
        this.SpecialRequest();
    }
}

public class PowerAdapter2 : IThreeHole
{
    TwoHole2 twoHole = new TwoHole2();
    public void Request()
    {
        twoHole.SpecialRequest();
    }
}