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
    public List<int> RightSideView(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<int> ans = new List<int>();
        
        while(queue.Count > 0)
        {
            int len = queue.Count;
            for(int i=0; i<len; i++)
            {
                TreeNode top = queue.Dequeue();
                if(top != null && i == len-1)
                    ans.Add(top.val);
                if(top != null && top.left != null)
                    queue.Enqueue(top.left);
                if(top != null && top.right != null)
                    queue.Enqueue(top.right);
            }

        }

        return ans;
    }
}
