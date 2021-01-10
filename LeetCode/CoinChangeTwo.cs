using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class CoinChangeTwo
    {
        public int Change(int amount, int[] coins)
        {
            int[][] dp = new int[coins.Length + 1][];
            
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[amount + 1];
                Array.Fill<int>(dp[i], 0);
                dp[i][0] = 1;
            }
            for (int row = 1; row < dp.Length; row++)
            {
                for(int col = 1; col < dp[row].Length; col++)
                {
                    if (col >= coins[row - 1])
                    {
                        int a = dp[row - 1][col];
                        int b = dp[row][col - coins[row - 1]];

                        dp[row][col] = a + b;
                    } else
                    {
                        dp[row][col] = dp[row - 1][col];
                    }
                }
            }
            return dp[coins.Length][amount];
        }
    }
}
