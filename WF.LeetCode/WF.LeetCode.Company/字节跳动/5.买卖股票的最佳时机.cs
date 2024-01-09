using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenFanLeetCode.TopicList
{
    /// <summary>
    ///121. 买卖股票的最佳时机
    ///题解：动态规划
    /// </summary>
    public class MaiGuPiaoDeShiJi
    {

        public int MaxProfit(int[] prices)
        {
            var n = prices.Length;
            var dp = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    dp[i, 0] = 0;
                    dp[i, 1] = -prices[i];
                    continue;
                }
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1, 1],  - prices[i]);
            }
            return dp[n - 1, 0];
        }

        public int MaxProfit1(int[] prices)
        {
            //dp[i][k][0 or 1]
            // 0 <= i <= n - 1, 1 <= k <= K
            // n 为天数，大 K 为交易数的上限，0 和 1 代表是否持有股票。
            // 此问题共 n × K × 2 种状态，全部穷举就能搞定。

            // for 0 <= i < n:
            //     for 1 <= k <= K:
            //         for s in { 0, 1}:
            //             dp[i][k][s] = max(buy, sell, rest)

            // base case：
            // dp[-1][...][0] = dp[...][0][0] = 0
            // dp[-1][...][1] = dp[...][0][1] = -infinity
            // 状态转移方程：
            // dp[i][k][0] = max(dp[i - 1][k][0], dp[i - 1][k][1] + prices[i])
            // dp[i][k][1] = max(dp[i - 1][k][1], dp[i - 1][k - 1][0] - prices[i])

            var n = prices.Length;
            var dp = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                if (i - 1 == -1)
                {

                    dp[0, 0] = 0;
                    // 根据状态转移方程可得：
                    //   dp[i][0]
                    // = max(dp[-1][0], dp[-1][1] + prices[i])
                    // = max(0, -infinity + prices[i]) = 0
                    dp[0, 1] = -prices[i];
                    // 根据状态转移方程可得：
                    //   dp[i][1]
                    // = max(dp[-1][1], dp[-1][0] - prices[i])
                    // = max(-infinity, 0 - prices[i])
                    // = -prices[i]
                    continue;
                }
                //dp[i][k][0] = max(dp[i - 1][k][0], dp[i - 1][k][1] + prices[i])
                //max(今天选择 rest, 今天选择 sell)
                // 解释：今天我没有持有股票，有两种可能，我从这两种可能中求最大利润：
                // 1、我昨天就没有持有，且截至昨天最大交易次数限制为 k；然后我今天选择 rest，所以我今天还是没有持有，最大交易次数限制依然为 k。
                // 2、我昨天持有股票，且截至昨天最大交易次数限制为 k；但是今天我 sell 了，所以我今天没有持有股票了，最大交易次数限制依然为 k
                dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);

                //dp[i][k][1] = max(dp[i - 1][k][1], dp[i - 1][k - 1][0] - prices[i])
                //max(今天选择 rest, 今天选择 buy)
                // 解释：今天我持有着股票，最大交易次数限制为 k，那么对于昨天来说，有两种可能，我从这两种可能中求最大利润：
                // 1、我昨天就持有着股票，且截至昨天最大交易次数限制为 k；然后今天选择 rest，所以我今天还持有着股票，最大交易次数限制依然为 k。
                // 2、我昨天本没有持有，且截至昨天最大交易次数限制为 k -1；但今天我选择 buy，所以今天我就持有股票了，最大交易次数限制为 k。
                dp[i, 1] = Math.Max(dp[i - 1, 1], - prices[i]);

            }

            return dp[n - 1, 0];
        }

    }
}