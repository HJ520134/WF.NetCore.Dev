using System.ComponentModel;

namespace TopicNormal.BFS;

public class 打开转盘锁
{
    public int OpenLock(string[] deadends, string target)
    {
        var quere = new Queue<string>();
        var visite = new HashSet<string>();
        var deads = new HashSet<string>();
        foreach (var item in deadends)
        {
            if (!visite.Contains(item))
            {
                deads.Add(item);
            }
        }

        quere.Enqueue("0000");
        visite.Add("0000");
        var maxCount = 0;
        while (quere.Count > 0)
        {
            var n = quere.Count;
            for (int i = 0; i < n; i++)
            {
                var curNum = (string)quere.Dequeue();

                if (deads.Contains(curNum))
                {
                    continue;
                }

                if (curNum.Equals(target))
                {
                    return maxCount;
                }

                for (int j = 0; j < 4; j++)
                {
                    var plusOneStr = PlusOne(curNum, j);
                    if (!visite.Contains(plusOneStr))
                    {
                        quere.Enqueue(plusOneStr);
                        visite.Add(plusOneStr);
                    }

                    var minsOneStr = MinsOne(curNum, j);
                    if (!visite.Contains(minsOneStr))
                    {
                        quere.Enqueue(minsOneStr);
                        visite.Add(minsOneStr);
                    }
                }

            }
            maxCount++;
        }

        return -1;
    }

    /// <summary>
    /// 网上拨一下
    /// </summary>
    /// <param name="cur"></param>
    /// <param name="j"></param>
    /// <returns></returns>
    public string PlusOne(string cur, int j)
    {
        var charNum = cur.ToCharArray();
        if (charNum[j] == '9')
        {
            charNum[j] = '0';
        }
        else
        {
            charNum[j] = (char)(charNum[j] + 1);
        }

        return new string(charNum);
    }

    /// <summary>
    /// 往下拨一下
    /// </summary>
    /// <param name="cur"></param>
    /// <param name="j"></param>
    /// <returns></returns>
    public string MinsOne(string cur, int j)
    {
        var charNum = cur.ToCharArray();
        if (charNum[j] == '0')
        {
            charNum[j] = '9';
        }
        else
        {
            charNum[j] = (char)(charNum[j] - 1);
        }

        return new string(charNum);
    }
}
