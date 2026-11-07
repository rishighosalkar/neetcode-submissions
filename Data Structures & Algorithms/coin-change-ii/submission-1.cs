public class Solution {
    public int DP(int[] coins, int target, int amount, int ind, int[,] dp)
    {
        if(ind >= coins.Length)
            return 0;

        if(amount == target){
            return 1;
        }

        if(dp[ind, amount] != -1)
            return dp[ind, amount];

        dp[ind, amount] = 0;
        if(coins[ind] + amount <= target)
            dp[ind, amount] += DP(coins, target, amount+coins[ind], ind, dp);

        dp[ind, amount] += DP(coins, target, amount, ind+1, dp);
        return dp[ind, amount];
    }
    public int Change(int amount, int[] coins) {
        int[,] dp = new int[coins.Length, amount];

        for(int i=0; i<coins.Length; i++)
            for(int j=0; j<amount; j++)
                dp[i, j] = -1;
        
        return DP(coins, amount, 0, 0, dp);
    }
}
