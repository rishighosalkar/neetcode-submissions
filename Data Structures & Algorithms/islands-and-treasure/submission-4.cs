public class Solution {

    public void islandsAndTreasure(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        Queue<(int, int)> q = new Queue<(int, int)>();  

        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                if(grid[i][j] == 0)
                    q.Enqueue((i, j));
            }
        }

        
        while(q.Count > 0)
        {
            var indexes = q.Dequeue();
            int i = indexes.Item1, j = indexes.Item2;
            if(i>0 && grid[i-1][j] == int.MaxValue)
            {
                q.Enqueue((i-1, j));
                grid[i-1][j] = grid[i][j]+1;
            }
            if(j>0 && grid[i][j-1] == int.MaxValue)
            {
                q.Enqueue((i, j-1));
                grid[i][j-1] = grid[i][j]+1;
            }
            if(i<m-1 && grid[i+1][j] == int.MaxValue)
            {
                q.Enqueue((i+1, j));
                grid[i+1][j] = grid[i][j]+1;
            }
            if(j<n-1 && grid[i][j+1] == int.MaxValue)
            {
                q.Enqueue((i, j+1));
                grid[i][j+1] = grid[i][j]+1;
            }
        }
    
    }
}
