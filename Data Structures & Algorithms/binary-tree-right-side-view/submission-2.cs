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
    List<int> ans = new List<int>();
    // public void DFS(TreeNode root, ref HashSet<int> set, int level)
    // {
    //     if(root == null)
    //         return;
        
    //     if(!set.Contains(level)){
    //         ans.Add(root.val);
    //         set.Add(level);
    //     }
    //     DFS(root.right, ref set, level+1);
    //     DFS(root.left, ref set, level+1);
    // }
    public List<int> RightSideView(TreeNode root) {
        Queue<TreeNode> q = new();

        q.Enqueue(root);

        while(q.Count > 0)
        {
            int len = q.Count;
            for(int i=0; i<len; i++)
            {
                TreeNode top = q.Dequeue();
                if(top!= null && i == len-1)
                    ans.Add(top.val);
                if(top != null && top.left != null)
                    q.Enqueue(top.left);
                if(top != null && top.right != null)
                    q.Enqueue(top.right);
            }
        }

        return ans == null ? [] : ans;   
    }
}
