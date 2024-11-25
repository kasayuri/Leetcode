public static Node Bfs(Node root)
{
    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(root);
    while (queue.Count > 0)
    {
        Node node = queue.Dequeue();
        foreach (Node child in node.children)
        {
            if (IsGoal(child))
            {
                return FOUND(child);
            }
            queue.Enqueue(child);
        }
    }
    return NOT_FOUND;
}
