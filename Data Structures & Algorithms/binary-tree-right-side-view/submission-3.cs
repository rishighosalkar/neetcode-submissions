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

        if(root == null)
            return new List<int>();
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<int> ans = new List<int>();
        ans.Add(root.val);
        while(queue.Count > 0)
        {
            int len = queue.Count;
            int isRight = 0;
            for(int i=0; i<len; i++)
            {
                TreeNode curr = queue.Dequeue();
                if(curr.right != null)
                {
                    queue.Enqueue(curr.right);
                    if(isRight == 0)
                    {
                        ans.Add(curr.right.val);
                        isRight = 1;
                    }
                }
                if(curr.left != null)
                {
                    queue.Enqueue(curr.left);
                    if(isRight == 0)
                    {
                        ans.Add(curr.left.val);
                        isRight = 1;
                    }
                }
            }

        }

        return ans;
    }
}
