public class Solution {
    public void Backtrack(int ind, int[] nums, int target, List<int> ds, int sum, List<List<int>> ans)
    {
        if(ind >= nums.Length)
        {
            if(sum == target)
                ans.Add(new List<int>(ds));
            
            return;
        }

        if(sum <= target)
        {
            ds.Add(nums[ind]);
            Backtrack(ind, nums, target, ds, sum + nums[ind], ans);
            ds.RemoveAt(ds.Count-1);
        }

        Backtrack(ind+1, nums, target, ds, sum, ans);
    }
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> ans = new();

        Backtrack(0, nums, target, new List<int>(), 0, ans);

        return ans;
    }
}
