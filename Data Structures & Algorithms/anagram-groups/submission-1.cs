public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> set = new Dictionary<string, List<string>>();
        
        List<List<string>> ans = new List<List<string>>();
        
        foreach(var str in strs)
        {
            int[] count = new int[26];
            foreach(var ch in str)
                count[ch - 'a']++;
            string s = string.Join(",", count);

            if(set.ContainsKey(s)){
                set[s].Add(str);
            }
            else
            {
                set.Add(s, new List<string> {str});
            }
        }

        foreach(var (key, val) in set)
            ans.Add(val);

        return ans;
    }
}
