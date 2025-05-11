namespace WF.DesignPattern.Category.单例模式;

/// <summary>
/// 私有构造函数的方式：线程安全
/// </summary>
public sealed class Singleton
{
    private static Singleton _singleton = new Singleton();

    public static int SingletonCount = 0;

    public static Singleton Instance
    {
        get { return _singleton; }
    }

    private Singleton()
    {
        SingletonCount++;
    }

    public void LogMessage(string message)
    {
        Console.WriteLine($"This is a log message.{message}");
    }
}