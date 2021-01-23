using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class JumpGameTwo
    {
        public int Jump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            // if only 2 elements or first step can reach the end then 1 step necesary
            if (nums.Length < 3 || nums[0] >= nums.Length - 1)
            {
                return 1;
            }

            int[] dp = new int[nums.Length];
            Array.Fill<int>(dp, nums.Length + 1);

            dp[0] = 0;
            dp[1] = 1;

            for (int i = 0; i < dp.Length; i++)
            {
                for (int j = i + nums[i]; j >= i; j--)
                {
                    if (j > dp.Length - 1) {
                        j = dp.Length - 1;
                    }

                    dp[j] = Math.Min(dp[i] + 1, dp[j]);
                }
            }

            return dp[dp.Length - 1];
        }
    }
}
