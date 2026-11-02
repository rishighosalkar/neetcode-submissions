public class Solution {
    public void Backtrack(List<List<int>> res, List<int> ds, bool[] vis, int[] nums)
    {
        if(ds.Count == nums.Length)
        {
            res.Add(new List<int> (ds));
            return;
        }

        for(int i=0; i<nums.Length; i++)
        {
            if(!vis[i])
            {
                vis[i] = true;
                ds.Add(nums[i]);
                Backtrack(res, ds, vis, nums);
                ds.RemoveAt(ds.Count-1);
                vis[i] = false;
            }
        }
    }
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new();
        Backtrack(res, new List<int>(), new bool[nums.Length], nums);

        return res;
    }
}
