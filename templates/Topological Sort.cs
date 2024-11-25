public static Dictionary<T, int> findInDegree<T>(Dictionary<T, List<T>> graph)
{
    Dictionary<T, int> inDegree = new Dictionary<T, int>();
    foreach (T node in graph.Keys)
    {
        inDegree.Add(node, 0);
    }
    foreach (T node in graph.Keys)
    {
        foreach (T neighbor in graph[parent])
        {
            inDegree[neighbor] += 1;
        }
    }
    return inDegree;
}

public static List<T> TopoSort<T>(Dictionary<T, List<T>> graph)
{
    List<T> res = new List<T>();
    Queue<T> queue = new Queue<T>();
    Dictionary<T, int> inDegree = findInDegree<T>(graph);
    foreach (T node in inDegree.Keys)
    {
        if (inDegree[node] == 0) queue.Enqueue(node);
    }
    while (queue.Count > 0)
    {
        T node = queue.Dequeue();
        res.Add(node);
        foreach (T neighbor in graph[node])
        {
            inDegree[neighbor] -= 1;
            if (inDegree[neighbor] == 0) queue.Enqueue(neighbor);
        }
    }
    return res;
}
