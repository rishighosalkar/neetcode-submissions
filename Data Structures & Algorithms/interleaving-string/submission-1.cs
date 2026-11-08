public class Solution {
    public bool DP(int ind1, int ind2, int ind3, string s1, string s2, string s3, string s, int[,] dp)
    {

        if(s == s3)
            return ind1 == s1.Length && ind2 == s2.Length;;
        
        if(ind1 < s1.Length && ind2 < s2.Length && dp[ind1, ind2] != -1)
            return dp[ind1, ind2] == 1 ? true : false;
        
        bool takeS1 = false, takeS2 = false;

        if(ind1 < s1.Length && s1[ind1] == s3[ind3])
            takeS1 = DP(ind1+1, ind2, ind3+1, s1, s2, s3, s+s1[ind1], dp);
        
        if(ind2 < s2.Length && s2[ind2] == s3[ind3])
            takeS2 = DP(ind1, ind2+1, ind3+1, s1, s2, s3, s+s2[ind2], dp);

        if(ind1 < s1.Length && ind2 < s2.Length)
            dp[ind1, ind2] = takeS1 || takeS2 ? 1 : 0;

        return takeS1 || takeS2;
    }
    public bool IsInterleave(string s1, string s2, string s3) {
        int[,] dp = new int[s1.Length, s2.Length];

        for(int i=0; i<s1.Length; i++)
            for(int j=0; j<s2.Length; j++)
                dp[i, j] = -1;
        
        return DP(0, 0, 0, s1, s2, s3, "", dp);
    }
}
