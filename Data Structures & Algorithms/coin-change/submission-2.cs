public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount+1];
        //
        Array.Fill(dp, amount+1);
        dp[0] = 0;
        
        for(int i=1; i<=amount; i++)
        {
            foreach(var coin in coins)
            {
                //coin = 1
                int target = i - coin;
                if(target >= 0)
                    dp[i] = Math.Min(dp[i], dp[target]+1);
                    
            }
        }
        
        return dp[amount] == amount+1 ? -1 : dp[amount];
    }
}
