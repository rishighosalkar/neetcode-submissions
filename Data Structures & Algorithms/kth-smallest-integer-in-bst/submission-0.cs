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
    public TreeNode Smallest(TreeNode root, ref int k)
    {
        if(root == null)
            return null;
        if(root.left == null && root.right == null)
        {
            k--;
            if(k == 0)
            {
                ans = root.val;
            } 
            return root;
        }
        TreeNode left = Smallest(root.left, ref k);
        k--;
        if(k == 0)
        {
            ans = root.val;
        } 
          
        TreeNode right = Smallest(root.right, ref k);
        
        return root;
    }
    public int KthSmallest(TreeNode root, int k) {
        Smallest(root,ref k);

        return ans;
    }
}
