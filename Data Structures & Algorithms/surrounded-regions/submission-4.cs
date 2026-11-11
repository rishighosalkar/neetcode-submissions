public class Solution {
    public void DFS(ref char[][] board, int r, int c, int[,] vis)
    {
        if(r >= board.Length || c >= board[0].Length || r<0 || c<0 || vis[r,c] == 1 || board[r][c] == 'X')
            return;
        
        
        if(board[r][c] == 'O')
        {
            board[r][c] = '#';
        }

        vis[r,c] = 1;
        DFS(ref board, r-1, c, vis);
        DFS(ref board, r, c-1, vis);
        DFS(ref board, r+1, c, vis);
        DFS(ref board, r, c+1, vis);
    }
    public void Solve(char[][] board) {
        int m=board.Length, n = board[0].Length;
        int[,] vis = new int[m,n];

        for(int i=0; i<m; i++)
        {
            if(board[i][0] == 'O')
                DFS(ref board, i, 0, vis);
            
            if(board[i][n-1] == 'O')
                DFS(ref board, i, n-1, vis);
        }

        for(int j=0; j<n; j++)
        {
            if(board[0][j] == 'O')
                DFS(ref board, 0, j, vis);

            if(board[m-1][j] == 'O')
                DFS(ref board, m-1, j, vis);
        }

        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                if(board[i][j] == '#')
                    board[i][j] = 'O';

                else if(board[i][j] == 'O')
                    board[i][j] = 'X';
            }
        }
    }
}
