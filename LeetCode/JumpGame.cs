using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            if (nums[0] == 0) {
                return false;
            }


            int[] dp = new int[nums.Length];
            Array.Fill<int>(dp, 0);

            dp[0] = 1;

            for (int i = 0; i < dp.Length - 1; i++)
            {
                for (int j = i + 1; j <= i + nums[i]; j++)
                {
                    if (j > dp.Length - 1)
                    {
                        dp[dp.Length - 1] = 1;
                        break;
                    }

                    dp[j] = 1;
                }
            }

            return !dp.Contains<int>(0);
        }
    }
}
