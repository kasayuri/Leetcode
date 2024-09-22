//https://leetcode.com/problems/implement-stack-using-queues/description/

public class MyStack {

    private Queue<int> fila;

    public MyStack() {
        fila = new Queue<int>();
    }
    
    public void Push(int x) { //adiciona em cima da pilha
        fila.Enqueue(x); //adiciona no final da fila
    }
    
    public int Pop() { //remove de cima da pilha
        for (int i = 0; i < fila.Count - 1; i++)
        {
            Push(fila.Dequeue());
        }
        return fila.Dequeue(); // não adiciona o último e retorna o valor
    }
    
    public int Top() { //ver o elemento em cima da pilha
        return fila.Last(); //retornar o primeiro elemento da pilha
    }
    
    public bool Empty() {
        return !fila.Any();
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
