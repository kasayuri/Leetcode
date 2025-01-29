# https://leetcode.com/problems/time-needed-to-buy-tickets/description/

# SEM Pilha/Fila

class Solution:
    def timeRequiredToBuy(self, tickets: List[int], k: int) -> int:
        soma = 0
        ajuste = 0
        for i in range(len(tickets)):
            if (i > k):
                ajuste = -1
            soma += min(tickets[i], tickets[k] + ajuste)
           #print(soma)
        return soma