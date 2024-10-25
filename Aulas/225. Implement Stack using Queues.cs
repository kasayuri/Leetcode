//https://leetcode.com/problems/implement-stack-using-queues/

/*
Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).

Implement the MyStack class:

    void push(int x) Pushes element x to the top of the stack.
    int pop() Removes the element on the top of the stack and returns it.
    int top() Returns the element on the top of the stack.
    boolean empty() Returns true if the stack is empty, false otherwise.

Notes:

    You must use only standard operations of a queue, which means that only push to back, peek/pop from front, size and is empty operations are valid.
    Depending on your language, the queue may not be supported natively. You may simulate a queue using a list or deque (double-ended queue) as long as you use only a queue's standard operations.
*/

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
