public class Solution {
    public bool ValidateCell(char ch, char[][] board, int row, int col)
    {
        for(int i=0; i<9; i++)
        {
            if(i != row && ch == board[i][col])
                return false;

            if(i != col && ch == board[row][i])
                return false;

            if(board[3 * (row/3) + i/3][3 * (col/3) + i % 3] == ch && (3 * (row/3) + i/3) != row && (3 * (col/3) + i % 3) != col)
                return false;
        }

        return true;
    }
    public bool IsValidSudoku(char[][] board) {

        for(int i=0; i<board.Length; i++)
        {
            for(int j=0; j<board[0].Length; j++)
            {
                if(board[i][j] != '.' && !ValidateCell(board[i][j], board, i, j))
                    return false;
            }
        }

        return true;
    }
}
