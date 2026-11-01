public class Solution {
    public void Backtrack(int ind, int[] nums, List<int> ds, ref List<List<int>> ans)
    {
        if(ind >= nums.Length)
        {            
            ans.Add(new List<int>(ds));
            return;
        }

        ds.Add(nums[ind]);
        
        Backtrack(ind+1, nums, ds, ref ans);
        ds.RemoveAt(ds.Count-1);
        Backtrack(ind+1, nums, ds, ref ans);
    }
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> ans = new();

        Backtrack(0, nums, new List<int>(), ref ans);

        return ans;
    }
}
