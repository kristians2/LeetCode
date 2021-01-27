using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class MaximumNumberofCoinsYouCanGet
    {
        public int MaxCoins(int[] piles) {
            int result = 0;
            int k = piles.Length / 3;
            
            Array.Sort<int>(piles);

            for (int i = piles.Length - 2; i > k - 1; i -= 2)
            {
                result += piles[i];
            }

            return result;
        }
    }
}
