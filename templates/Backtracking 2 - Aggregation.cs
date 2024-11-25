public static int Dfs(int startIndex, List<T> target)
{
    if (IsLeaf(startIndex))
    {
        return 1;
    }
    int ans = initialValue;
    foreach (T edge : getEdges(startIndex, [...additional states]))
    {
        if (additional states) {
            update([...additional states]);
        }
        ans = aggregate(ans, dfs(startIndex + edge.length(), [...additional states])
        if (additional states) {
            revert([...additional states]);
        }
    }
    return ans;
}
