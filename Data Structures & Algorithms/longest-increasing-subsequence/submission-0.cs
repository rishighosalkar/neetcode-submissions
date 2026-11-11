public class Solution {
    public int DP(int[] nums, int ind, int prev, int[,] dp)
    {
        if(ind >= nums.Length)
            return 0;

        if(prev != -1 && dp[ind, prev] != -1)
            return dp[ind, prev];

        int len = 0;
        if(prev == -1 || nums[ind] > nums[prev])
            len = Math.Max(len, 1 + DP(nums, ind+1, ind, dp));

        len = Math.Max(len, DP(nums, ind+1, prev, dp));

        if(prev != -1)
            dp[ind, prev] = len;
        
        return len;
    }
    public int LengthOfLIS(int[] nums) {
        int[,] dp = new int[nums.Length, nums.Length+1];
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=0; j<nums.Length; j++)
            {
                dp[i, j] = -1;
            }
        }

        return DP(nums, 0, -1, dp);
    }
}
