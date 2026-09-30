public class Solution {
    public int TraverseIslands(int[][] grid, int i, int j, ref int[,] vis)
    {
        if(i>=grid.Length || i<0 || j>=grid[0].Length || j<0 || grid[i][j] == 0 || vis[i,j] == 1)
            return 0;

        vis[i,j] = 1;

        int right = TraverseIslands(grid, i, j+1, ref vis);
        int down = TraverseIslands(grid, i+1, j, ref vis);
        int left = TraverseIslands(grid, i, j-1, ref vis);
        int top = TraverseIslands(grid, i-1, j, ref vis);

        return 1 + right + left+top+down;
    }
    public int MaxAreaOfIsland(int[][] grid) {
        int m = grid.Length, n = grid[0].Length, ans = 0;
        int[,] vis = new int[m,n];
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                if(grid[i][j] == 1 && vis[i,j] == 0)
                    ans = Math.Max(ans, TraverseIslands(grid, i, j, ref vis));
            }
        }

        return ans;
    }
}
