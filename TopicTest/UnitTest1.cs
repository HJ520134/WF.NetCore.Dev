
using TopicNormal.动态规划.打家劫舍2;

namespace TopicTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();

    }

    [Test]
    public void Solution()
    {
        var solution = new Solution();

        var nums = new int[] { 1, 2, 3, 1 };
        solution.Rob(nums);
    }

}