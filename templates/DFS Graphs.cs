public static void Dfs(Node root, HashSet<Node> visited)
{
    foreach (Node neighbor in node.neighbors)
    {
        if (visited.Contains(node))
        {
            continue;
        }
        visited.Add(neighbor);
        Dfs(neighbor, visited);
    }
}
