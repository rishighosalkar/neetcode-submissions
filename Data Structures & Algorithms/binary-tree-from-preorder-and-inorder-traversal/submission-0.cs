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
    public TreeNode CreateTree(int preStart, int preEnd, int inStart, int inEnd, int[] preorder, int[] inorder, Dictionary<int, int> inOrderIndex)
    {
        if(preStart > preEnd || inStart > inEnd)
            return null;
        
        TreeNode root = new TreeNode(preorder[preStart]);
        int leftLen = inOrderIndex[preorder[preStart]] - inStart;
        int rightLen = inEnd - inOrderIndex[preorder[preStart]];


        root.left = CreateTree(preStart+1, preStart+leftLen, inStart, inOrderIndex[preorder[preStart]]-1, preorder, inorder, inOrderIndex);

        root.right = CreateTree(preStart+leftLen+1, preEnd, inOrderIndex[preorder[preStart]]+1, inEnd, preorder, inorder, inOrderIndex);
        
        return root;
    }
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        Dictionary<int, int> inOrderIndex = new Dictionary<int, int>();

        for(int i=0; i<inorder.Length; i++)
            inOrderIndex.Add(inorder[i], i);

        return CreateTree(0, preorder.Length-1, 0, inorder.Length-1, preorder, inorder, inOrderIndex);
    }
}
