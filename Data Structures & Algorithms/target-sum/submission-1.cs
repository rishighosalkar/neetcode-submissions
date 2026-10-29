public class Solution {
    Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();

    public int DP(int ind, int[] nums, int target, int sum)
    {
        if(ind >= nums.Length)
            return sum == target ? 1 : 0;
        
        var state = (ind, sum);
        if(memo.ContainsKey(state))
            return memo[state];
        
        memo.Add(state, DP(ind+1, nums, target, sum+nums[ind])
            +DP(ind+1, nums, target, sum-nums[ind])
        );

        return memo[state];
    }
    public int FindTargetSumWays(int[] nums, int target) {
        
        return DP(0, nums, target, 0);
    }
}
