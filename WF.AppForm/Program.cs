// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    int temp = i;
    new Thread(() => Console.WriteLine($"次数：{temp}")).Start();
}
Console.WriteLine("Hello, World!");
