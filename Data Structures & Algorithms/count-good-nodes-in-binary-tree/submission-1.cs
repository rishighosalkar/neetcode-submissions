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

        if(root.val >= maxNode)
        {
            ans++;
            maxNode = root.val;
        }
        
        CountNode(root.left, maxNode);
        CountNode(root.right, maxNode);
    }
    public int GoodNodes(TreeNode root) {
        if(root == null)
            return 0;

        CountNode(root, root.val);

        return ans;
    }
}
