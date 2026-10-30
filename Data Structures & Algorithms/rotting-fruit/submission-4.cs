public class Solution {
    public int OrangesRotting(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        Queue<(int r, int c)> q = new Queue<(int r, int c)>();
        int ans = 0, fresh = 0;
        
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                if(grid[i][j] == 2)
                    q.Enqueue((i, j));
                else if(grid[i][j] == 1)
                    fresh++;
            }
        }

        int[][] dirs = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 }
        };

        while(q.Count > 0 && fresh > 0)
        {
            int size = q.Count;
            for(int i=0; i<size; i++)
            {
                var (r, c) = q.Dequeue();
                foreach(var dir in dirs)
                {
                    int nr = r + dir[0], nc = c + dir[1];
                    if(nr < 0 || nc < 0 || nr >=m || nc >= n)
                        continue;

                    if(grid[nr][nc] == 1)
                    {
                        q.Enqueue((nr, nc));
                        fresh--;
                        grid[nr][nc] = 2;
                    }
                }
            }

            ans++;
        }

        return fresh > 0 ? -1 : ans;
    }
}
