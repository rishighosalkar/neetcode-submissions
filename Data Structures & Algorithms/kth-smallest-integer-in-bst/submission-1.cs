/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    int ans = 0;
    public bool DFS(TreeNode root, ref int k)
    {
        if(root == null)
            return false;
        
        if(DFS(root.left, ref k))
            return true;
        k--;
        if(k == 0)
        {
            ans = root.val;
            return true;
        } 
          
        return DFS(root.right, ref k);
    }
    public int KthSmallest(TreeNode root, int k) {
        DFS(root,ref k);

        return ans;
    }
}
