public static int numRows = grid.Count;
public static int numCols = grid[0].Count;

public static List<Coordinate> GetNeighbors(Coordinate coord)
{
    int row = coord.row;
    int col = coord.col;
    int[] deltaRow = {-1, 0, 1, 0};
    int[] deltaCol = {0, 1, 0, -1};
    List<Coordinate> res = new List<Coordinate>();
    for (int i = 0; i < deltaRow.Length; i++)
    {
        int neighborRow = row + deltaRow[i];
        int neighborCol = col + deltaCol[i];
        if (0 <= neighborRow && neighborRow < numRows &&
        0 <= neighborCol && neighborCol < numCols)
        {
            res.Add(new Coordinate(neighborRow, neighborCol));
        }
    }
    return res;
}

public static void Bfs(Coordinate startingNode)
{
    Queue<Coordinate> queue = new Queue<Coordinate>();
    queue.Enqueue(startingNode);
    HashSet<Coordinate> visited = new HashSet<Coordinate>();
    visited.Add(startingNode);
    while (queue.Count > 0)
    {
        Coordinate node = queue.Dequeue();
        foreach (Coordinate neighbor in GetNeighbors(node))
        {
            if (visited.Contains(neighbor)) continue;
            // Do stuff with the node if required
            // ...
            queue.Enqueue(neighbor);
            visited.Add(neighbor);
        }
    }
}
