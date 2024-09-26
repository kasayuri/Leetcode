//https://leetcode.com/problems/binary-tree-paths/description/?envType=problem-list-v2&envId=tree
//Não deu certo usar o StringBuilder com essa lógica, pq ele estava removendo o 'histórico' dos paths anteriores

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
    public IList<string> BinaryTreePaths(TreeNode root) {
        List<string> result = new List<string>();

        string path = string.Empty;
        GetStringPaths(root, path, result);

        return result;
    }

    //[1,2,3,null,5]
    public void GetStringPaths(TreeNode root, string path, List<string> paths){
    
        if(root != null){
            path += root.val;

            //se folha
            if (root.left == null && root.right == null){
                paths.Add(path);
            } else {
                path += "->";
                GetStringPaths(root.left, path, paths);
                GetStringPaths(root.right, path, paths);
            }
        }
    }
}
