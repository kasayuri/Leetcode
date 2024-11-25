public static void Dfs(int startIndex, List<T> path, List<List<T>> res, [...additional states])
{
    if (isLeaf(path))
    {
        // add a copy of the path to the result
        res.Add(new List<T>(path));
        return;
    }
    foreach (T edge in getEdges(startIndex, [...additional states]))
    {
        path.Add(choice);
        if (...additional states) update(...additional states)
        Dfs(startIndex + edge.length(), path, res, [...addtional states]);
        path.RemoveAt(path.Count - 1);
        // revert(...additional states) if necessary, e.g. permutations
    }
}
