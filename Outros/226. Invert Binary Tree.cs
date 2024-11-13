//https://leetcode.com/problems/invert-binary-tree/description/
//Given the root of a binary tree, invert the tree, and return its root.

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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
            return null;
        
        TreeNode novo = new TreeNode(root.val);

        novo.left = InvertTree(root.right);
        novo.right = InvertTree(root.left);

        return novo;
    }
}
