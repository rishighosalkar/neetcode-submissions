public class Solution {
    public int DP(int[] nums, int ind, ref int[] dp)
    {
        if(ind >= nums.Length)
            return 0;

        if(dp[ind] != -1)
            return dp[ind];

        return dp[ind] = Math.Max(nums[ind] + DP(nums, ind+2, ref dp), DP(nums, ind+1, ref dp));
    }
    public int Rob(int[] nums) {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, -1);
        
        return DP(nums, 0, ref dp);
    }
}
