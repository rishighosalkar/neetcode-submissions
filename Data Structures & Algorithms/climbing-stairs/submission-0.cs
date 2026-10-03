public class Solution {
    
    public int DP(int n, ref int[] dp)
    {
        if(n < 0)
            return 0;

        if(n == 0)
            return 1;
    
        if(dp[n] != -1)
            return dp[n];

        dp[n] = DP(n-1, ref dp) + DP(n-2, ref dp);

        return dp[n];
    }
    public int ClimbStairs(int n) {     
        int[] dp = new int[n+1];

        Array.Fill(dp, -1);

        return DP(n, ref dp);
    }
}
