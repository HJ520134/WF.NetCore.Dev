namespace WF.LeetCode.Category.滑动窗口
{
    internal class _438
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var need = new Dictionary<char, int>();
            foreach (var item in p.ToCharArray())
            {
                if (need.ContainsKey(item))
                {
                    need[item] += 1;
                }
                else
                {
                    need.Add(item, 1);
                }
            }

            var window = new Dictionary<char, int>();
            var left = 0; int right = 0;
            var len = p.Length;
            var result = new List<int>();
            var voild = 0;
            while (right < s.Length)
            {
                var cur = s[right];
                right++;
                if (need.ContainsKey(cur))
                {
                    if (window.ContainsKey(cur))
                    {
                        window[cur] += 1;
                    }
                    else
                    {
                        window.Add(cur, 1);
                    }

                    if (window[cur].Equals(need[cur]))
                    {
                        voild++;
                    }
                }

                while (right - left >= p.Length)
                {
                    if (voild == need.Count)
                    {
                        result.Add(left);
                    }

                    var leftCahar = s[left];
                    left++;
                    if (need.ContainsKey(leftCahar))
                    {
                        if (window[leftCahar].Equals(need[leftCahar]))
                        {
                            voild--;
                        }

                        window[leftCahar] -= 1;
                    }
                }
            }

            return result;
        }
    }
}
