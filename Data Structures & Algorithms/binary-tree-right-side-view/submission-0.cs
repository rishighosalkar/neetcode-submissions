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
    public void DFS(TreeNode root, ref HashSet<int> set, int level)
    {
        if(root == null)
            return;
        
        if(!set.Contains(level)){
            ans.Add(root.val);
            set.Add(level);
        }
        DFS(root.right, ref set, level+1);
        DFS(root.left, ref set, level+1);
    }
    public List<int> RightSideView(TreeNode root) {
        HashSet<int> set = new HashSet<int>();
        DFS(root, ref set, 0);

        return ans;   
    }
}
