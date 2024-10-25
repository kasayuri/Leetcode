// https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/description/

/*
Estratégia: O array students é uma fila (início na posição 0) enquanto o array sandwiches é uma pilha (topo na posição 0).
Podemos fazer uma simulação da execução: retira o elemento do início da fila e compara com o elemento no topo da pilha. 
Se forem iguais, faz um pop na pilha. Se forem diferentes, coloca o elemento no final da fila. 
Fazemos isso enquanto a fila e pilha não estiverem vazias.
Além disso, temos que contar quantas vezes tiramos um elemento da fila e colocamos de volta em sequência. Se esse número for igual ao tamanho da
fila, significa que todo mundo saiu e entrou de novo na fila, ou seja, nenhum elemento da fila é igual ao topo da pilha. Nesse caso paramos o
algoritmo e retornamos como resposta o número de elementos da fila.
*/

public class Solution {

public int CountStudents(int[] students, int[] sandwiches)
{
    var queue = new Queue<int>(students);
    var stack = new Stack<int>(sandwiches.Reverse());
    var rotationCount = 0;
    do
    {
        var preference = queue.Dequeue();
        if (preference == stack.Peek())
        {
            rotationCount = 0;
            stack.Pop();
        }
        else
        {
            rotationCount++;
            queue.Enqueue(preference);
        }
    } while (rotationCount < queue.Count && stack.Count > 0 && queue.Count > 0);

    return queue.Count;
}
}
