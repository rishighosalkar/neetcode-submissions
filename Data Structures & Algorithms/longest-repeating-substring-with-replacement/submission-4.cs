public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] ch = new int[256];

        int start = 0, end = 0, n = s.Length, ans = 0, maxFreq = 0;
        
        while(end < n)
        {
            ch[s[end]]++;
            
            maxFreq = Math.Max(maxFreq, ch[s[end]]);

            while((end-start+1) - maxFreq > k)
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
