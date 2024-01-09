
public class ZuiChangZiChuan
{
    /// <summary>
    /// 3. 无重复字符的最长子串 思路：滑动窗口
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 2)
        {
            return s.Length;
        }
        int left = 0;
        int right = 0;
        int maxLen = 0;
        var hashSet = new HashSet<char>();
        while (right < s.Length)
        {
            if (!hashSet.Contains(s[right]))
            {
                hashSet.Add(s[right++]);
                maxLen = Math.Max(maxLen, right - left);
            }
            else
            {
                hashSet.Remove(s[left++]);
            }
        }

        return maxLen;
    }
}