public static Node Dfs(Node root, int target)
{
    if (root == null) return null;
    if (root.val == target) 
    {
        return root;
    }
    Node left = Dfs(root.left, target);
    if (left != null) 
    {
        return left;
    }
    return Dfs(root.right, target);
}
