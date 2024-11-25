public static void Bfs(Node root)
{
    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(root);
    HashSet<Node> visited = new HashSet<Node>();
    visited.Add(root);
    while (queue.Count > 0)
    {
        Node node = queue.Dequeue();
        foreach (Node neighbor in GetNeighbors(node))
        {
            if (visited.Contains(neighbor))
            {
                continue;
            }
            queue.Enqueue(neighbor);
            visited.Add(neighbor);
        }
    }
}
