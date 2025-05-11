namespace WenFanLeetCode.TopicList;

/// <summary>
/// 丑数 就是只包含质因数 2、3 和 5 的 正 整数。给你一个整数 n ，请你判断 n 是否为 丑数 。如果是，返回 true ；否则，返回 false 。
/// </summary>
public class 丑数
{
    public bool IsUgly(int n)
    {
        if (n<1)
        {
            return false;
        }
        var factors = new int[]
        {
            2, 3, 5
        };
        foreach (var factor in factors)
        {
            while (n % factor == 0)
            {
                n= n / factor;
            }
        }

        return n == 1;
    }
}