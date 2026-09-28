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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> ans = new List<List<int>>();
        Queue<TreeNode> q = new();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            int len = q.Count;
            List<int> level = new();
            for(int i=0; i<len; i++)
            {
                TreeNode front = q.Dequeue();
                if(front != null)
                {
                    level.Add(front.val);
                    if(front.left != null)
                        q.Enqueue(front.left);
                    if(front.right != null)
                        q.Enqueue(front.right);
                }
            }
            if(level != null)
                ans.Add(level);
        }
        // Console.WriteLine(ans.Count);
        return ans[0].Count == 0 ? [] : ans;
    }
}
