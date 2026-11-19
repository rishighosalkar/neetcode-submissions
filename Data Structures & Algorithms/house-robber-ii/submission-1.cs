public class Solution {
    public int DP(int ind, int[] nums, int[] dp, int n)
    {
        if(ind >= n)
        {
            return 0;
        }

        if(dp[ind] != -1)
            return dp[ind];
        
        int rob = nums[ind] + DP(ind+2, nums, dp, n);
        int skip = DP(ind+1, nums, dp, n);

        return dp[ind] = Math.Max(skip, rob);
    }
    public int Rob(int[] nums) {
        int n = nums.Length;

        if (n == 0) return 0;
        if (n == 1) return nums[0];
        
        int[] dp1 = new int[n];
        int[] dp2 = new int[n];
        Array.Fill(dp1, -1);
        Array.Fill(dp2, -1);
        return Math.Max(DP(0, nums, dp1, n-1), DP(1, nums, dp2, n));
    }
}
