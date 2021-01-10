using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                } else
                {
                    int diff = prices[i] - min;

                    if (maxProfit < diff)
                    {
                        maxProfit = diff;
                    }
                }
            }

            return maxProfit;
        }
    }
}
