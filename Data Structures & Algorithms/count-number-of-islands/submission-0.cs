public class Solution {
    public void TraverseIslands(char[][] grid, int i, int j, ref int[,] vis)
    {
        if(i>= grid.Length || i<0 || j>= grid[0].Length || j<0 || grid[i][j] == '0' || vis[i,j] == 1)
            return;
        
        vis[i,j] = 1;
        
        TraverseIslands(grid, i, j+1, ref vis);
        TraverseIslands(grid, i+1, j, ref vis);
        TraverseIslands(grid, i, j-1, ref vis);
        TraverseIslands(grid, i-1, j, ref vis);
    }
    public int NumIslands(char[][] grid) {
        int m = grid.Length, n = grid[0].Length, ans = 0;
        int[,] vis = new int[m,n];
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                if(grid[i][j] == '1' && vis[i, j] == 0){
                    TraverseIslands(grid, i, j, ref vis);
                    ans++;
                }
            }
        }

        return ans;
    }
}
