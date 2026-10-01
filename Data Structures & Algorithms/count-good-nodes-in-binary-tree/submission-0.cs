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
    public void CountNode(TreeNode root, int maxNode)
    {
        if(root == null)
            return;

        if(root.val >= maxNode){
            ans++;
        }
        
        CountNode(root.left, Math.Max(maxNode, root.val));
        CountNode(root.right, Math.Max(maxNode, root.val));
    }
    public int GoodNodes(TreeNode root) {
        CountNode(root, root.val);

        return ans;
    }
}
