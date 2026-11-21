public class Solution {
    public int DP(int[] nums, int ind, int[] dp)
    {
        if(ind >= nums.Length)
            return int.MaxValue;

        if(ind == nums.Length-1)
            return 0;

        if(dp[ind] != -1)
            return dp[ind];
        
        int jumps = int.MaxValue;
        for(int i=1; i<=nums[ind]; i++)
        {
            int nextInd = ind+i;
            if(nextInd >= nums.Length)
                break;
            int jump = DP(nums, ind+i, dp);
            int take = (jump == int.MaxValue) ? jump : 1 + jump;
            jumps = Math.Min(jumps, take);
        }

        return dp[ind] = jumps;
    }
    public int Jump(int[] nums) {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, -1);

        return DP(nums, 0, dp);
    }
}
