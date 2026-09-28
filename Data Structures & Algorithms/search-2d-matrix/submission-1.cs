public class Solution {
    bool ans = false;
    public bool Search(int[][] matrix, int target, int i, int j)
    {
        Console.WriteLine(i + ", " + j + ", " + matrix[i][j]);
        if(i<0 || i>= matrix.Length || j<0 || j>= matrix[0].Length)
            return false;
            
        if(matrix[i][j] == target)
            return true;
        else if(i>0 && target <= matrix[i-1][j])
            return Search(matrix, target, i-1, j);
        else if(j>0)
            return Search(matrix, target, i, j-1);
        
        return false;
    }
    public bool SearchMatrix(int[][] matrix, int target) {
        Console.WriteLine(matrix.Length + ", " + matrix[0].Length);
        return Search(matrix, target, matrix.Length-1, matrix[0].Length-1);
    }
}
