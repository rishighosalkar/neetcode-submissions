public class Solution {
    public int DP(int[] coins, int target, int ind, int amount, ref int[,] dp)
    {
        if(ind >= coins.Length || amount > target)
        {
            return int.MaxValue;
        }

        if(amount == target)
        {
            return 0;
        }

        if(dp[ind, amount] != -1)
            return dp[ind, amount];

        int length = int.MaxValue;
        if(coins[ind] <= target - amount)
        {
            length = DP(coins, target, ind, amount+coins[ind], ref dp);
            length = length == int.MaxValue ? length : 1 + length;
        }

        dp[ind, amount] = Math.Min(length, DP(coins, target, ind+1, amount, ref dp));
        return dp[ind, amount];
    }
    public int CoinChange(int[] coins, int amount) {
        int[,] dp = new int[coins.Length,amount+1];
        for(int i=0; i<coins.Length; i++)
        {
            for(int j=0; j<=amount; j++)
            {
                dp[i,j] = -1;
            }
        }

        int ans = DP(coins, amount, 0, 0, ref dp);

        return ans == int.MaxValue ? -1 : ans;
    }
}
