public class Solution {

    public string LongestPalindrome(string s) {
        int maxLen = 0, n = s.Length, resInd=0;

        for(int i=0; i<s.Length; i++)
        {
            int l=i, r=i;

            while(l>=0 && r<n && s[l] == s[r])
            {
                if(r-l+1 > maxLen)
                {
                    maxLen = r-l+1;
                    resInd = l;
                }
                l--;
                r++;
            }

            l=i;
            r=i+1;
            while(l>=0 && r<n && s[l] == s[r])
            {
                if(r-l+1 > maxLen)
                {
                    maxLen = r-l+1;
                    resInd = l;
                }
                l--;
                r++;
            }

        }

        return s.Substring(resInd, maxLen);
    }
}
