public class Solution {
    public int DP(int ind1, int ind2, string t1, string t2, int len, ref int[,] dp)
    {
        if(ind1 >= t1.Length || ind2 >= t2.Length)
            return 0;

        if(dp[ind1, ind2] != -1)
            return dp[ind1, ind2];
        
        if(t1[ind1] == t2[ind2])
            dp[ind1, ind2] = 1 + DP(ind1 + 1, ind2 + 1, t1, t2, len + 1, ref dp);

        else
        {
            dp[ind1, ind2] = Math.Max(DP(ind1 + 1, ind2, t1, t2, len, ref dp),
            DP(ind1, ind2 + 1, t1, t2, len, ref dp));
        }

        return dp[ind1, ind2];
    }
    public int LongestCommonSubsequence(string text1, string text2) {
        int[,] dp = new int[text1.Length, text2.Length];
        for (int i = 0; i < text1.Length; i++)
        {
            for (int j = 0; j < text2.Length; j++)
            {
                dp[i, j] = -1;
            }
        }

        DP(0, 0, text1, text2, 0, ref dp);

        return dp[0, 0];
    }
}
