public class Solution {

    public int MinCostConnectPoints(int[][] points) {
        // criar uma lista com os pontos visitados
        // criar um heap e var de total
        // adicionar todas as combinacoes entre cada ponto

        int custoTotal = 0;
        HashSet<int> visitados = new HashSet<int>();
        PriorityQueue<(int inicio, int fim), int> heap 
                = new PriorityQueue<(int inicio, int fim), int>(); //(0,1),4

        visitados.Add(0); //add primeiro ponto

        for (int j = 1; j < n; j++) {
            var distancia = CalculaManhattan(points, 0, j);
            heap.Enqueue((0, j), distancia);
        }

        while (visitados.Count < n) {
            var (inicio, fim) = heap.Dequeue();
            if (visitados.Contains(fim)) continue;

            visitados.Add(fim);
            totalCost += CalculaManhattan(points, inicio, fim);

            for (int j = 0; j < n; j++) {
                if (!visitados.Contains(j)) {
                    var distancia = CalculaManhattan(points, fim, j);
                    heap.Enqueue((fim, j), distancia);
                }
            }
        }

        return custoTotal;
    }

    public int CalculaManhattan(int[][] points, int i, int j){
        var diferenca = Math.Abs( points[i][0] - points[j][0])
                + Math.Abs(points[i][1] - points[j][1]);

        return diferenca;
    }

}