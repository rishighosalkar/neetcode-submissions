public class Solution {
    int maxProfit = int.MinValue;
    public int DP(int[] prices, int ind, int canBuy, int[,] dp)
    {
        if(ind >= prices.Length)
            return 0;

        if(dp[ind, canBuy] != -1)
            return dp[ind, canBuy];

        int result;
        if(canBuy == 1)
        {
            int buy = -prices[ind] + DP(prices, ind+1, 0, dp);
            int skip = DP(prices, ind+1, 1, dp);

            result = Math.Max(buy, skip);
        }
        else
        {
            int sell = prices[ind] + DP(prices, ind+2, 1, dp);
            int skip = DP(prices, ind+1, 0, dp);

            result = Math.Max(sell, skip);
        }

        return dp[ind, canBuy] = result;
    }
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int[,] dp = new int[n, 2];

        for (int i = 0; i < n; i++)
        {
            dp[i, 0] = -1;
            dp[i, 1] = -1;
        }

        return DP(prices, 0, 1, dp);
    }
}
