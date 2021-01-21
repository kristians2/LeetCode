using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            Array.Fill<int>(dp, 1);

            for (int i = 1; i < dp.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        if (dp[j] > max)
                        {
                            max = dp[j];
                        }
                    }
                }

                dp[i] = max + 1;
            }

            return dp.Max();
        }
    }
}
