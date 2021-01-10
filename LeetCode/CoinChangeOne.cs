using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CoinChangeOne
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];

            Array.Fill<int>(dp, amount + 1);

            dp[0] = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }

            return dp[dp.Length - 1] > amount ? -1 : dp[dp.Length - 1];
        }
    }
}
