public class Solution {
    int ans = 0;
    public int DP(int r, int c, int m, int n, ref int[,] vis)
    {
        if(r>=m || c >= n)
            return 0;

        if(r == m-1 && c == n-1)
            return 1;
        
        if(vis[r,c] != 0)
            return vis[r,c];

        int right = DP(r, c+1, m, n, ref vis);
        int down = DP(r+1, c, m, n, ref vis);
        
        return vis[r,c] = right+down;
    }
    public int UniquePaths(int m, int n) {
        int[,] vis = new int[m,n];
        // Array.Fill(vis, -1);
        
        return DP(0, 0, m, n, ref vis);
    }
}
