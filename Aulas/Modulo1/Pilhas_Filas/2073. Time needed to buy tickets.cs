// https://leetcode.com/problems/time-needed-to-buy-tickets/

/*
There are n people in a line queuing to buy tickets, where the 0th person is at the front of the line and the (n - 1)th person is at the back of the line.
You are given a 0-indexed integer array tickets of length n where the number of tickets that the ith person would like to buy is tickets[i].
Each person takes exactly 1 second to buy a ticket. A person can only buy 1 ticket at a time and has to go back to the end of the line (which happens instantaneously) in order to buy more tickets. If a person does not have any tickets left to buy, the person will leave the line.
Return the time taken for the person initially at position k (0-indexed) to finish buying tickets.
*/

/*
Estratégia: criar uma fila em que os elementos armazenam o índice e a quantidade de tickets restantes para comprar.
Enquanto o elemento de índice k ainda tiver tickets restantes para comprar, retiramos o primeiro elemento da fila,
decrementamos a quantidade de tickets restantes para comprar, e colocamos de volta no final da fila caso necessário.
A cada iteração do loop, somamos 1 unidade de tempo.
*/

public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int time = 0;
        var queue = new Queue<Entry>();
        for (int i = 0; i < tickets.Length; i++) {
            var entry = new Entry();
            entry.id = i;
            entry.tickets = tickets[i];
            queue.Enqueue(entry);
        }
        bool finished = false;

        while (!finished) {
            time++;
            var entry = queue.Dequeue();
            entry.tickets--;
            if (entry.tickets == 0 && entry.id == k) {
                finished = true;
                continue;
            }
            if (entry.tickets > 0) queue.Enqueue(entry);
        }
        return time;
    }

class Entry {
    public int id;
    public int tickets;
    }
}
