public class Solution {
    public void Backtrack(int ind, int[] cand, int target, int sum, List<int> ds, List<List<int>> ans)
    {
        if(sum == target)
        {
            ans.Add(new List<int>(ds));    
            return;
        }
        
        for(int i=ind; i<cand.Length; i++)
        {
            if(i>ind && cand[i] == cand[i-1])
                continue;

            if(sum+cand[i] > target)
                break;

            ds.Add(cand[i]);
            Backtrack(i+1, cand, target, sum+cand[i], ds, ans);
            ds.RemoveAt(ds.Count-1);
        }
    }
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> ans = new();
        Array.Sort(candidates);
        Backtrack(0, candidates, target, 0, new List<int>(), ans);

        return ans;
    }
}
