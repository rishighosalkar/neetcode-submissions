public class Solution {
    public bool Recurr(int[] nums, int ind, ref int[] dp)
    {
        if(ind >= nums.Length)
            return false;

        if(ind == nums.Length-1)
            return true;

        if(nums[ind] == 0)
            return false;
        
        bool canReachEnd = false;
        for(int i=1; i<=nums[ind]; i++)
        {
            int currInd = ind+i;
            
            if(currInd >= nums.Length)
                break;
            
            if(dp[ind+i] != -1)
                canReachEnd = canReachEnd || (dp[ind+i] == 1 ? true : false);
            else
                canReachEnd = canReachEnd || Recurr(nums, ind+i, ref dp);
        }

        dp[ind] = canReachEnd ? 1 : 0;

        return canReachEnd;
    }
    public bool CanJump(int[] nums) {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, -1);
        return Recurr(nums, 0, ref dp);
    }
}
