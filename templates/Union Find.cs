public class UnionFind<T> {
    private Dictionary<T, T> id = new Dictionary<T, T>();

    public T Find(T x) {
        T y = id.GetValueOrDefault(x, x);
        if (!y.Equals(x)) {
            y = Find(y);
            id[x] = y;
        }
        return y;
    }

    public void Union(T x, T y) {
        id[Find(x)] = Find(y);
    }
}
