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
    public bool ValidateBST(TreeNode root, int lowerLimit, int upperLimit)
    {
        if(root == null)
            return true;

        if(root.val <= lowerLimit || root.val >= upperLimit)
            return false;
        
        bool left = ValidateBST(root.left, lowerLimit, root.val);
        bool right = ValidateBST(root.right, root.val, upperLimit);

        return left && right;
    }
    public bool IsValidBST(TreeNode root) {
        return ValidateBST(root, int.MinValue, int.MaxValue);
    }
}
