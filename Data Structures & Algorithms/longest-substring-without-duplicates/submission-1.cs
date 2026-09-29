public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[] ch = new int[256];

        int start = 0, end = 0, ans = 0;

        while(end < s.Length)
        {
            ch[s[end]]++;   
            while(ch[s[end]] > 1 && start <= end)
            {
                ch[s[start]]--;
                start++;
            }
            
            ans = Math.Max(ans, end-start+1);
            end++;
        }

        return ans;
    }
}
