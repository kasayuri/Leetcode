# https://leetcode.com/problems/swapping-nodes-in-a-linked-list/


#THREE PASS (ONE PASS EMBAIXO)

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def swapNodes(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        # contar quantos elementos tem na lista
        # contador para direita e outro para a esquerda
        # swap dos dois

        # verificar se k > tamanho da lista
        first = ListNode(0, head)
        tamanho = 1
        valor1, valor2 = 0, 0

        #busca 1o. valor e tamanho lista
        while head:
            if (tamanho == k):
                valor1 = head.val
            tamanho += 1
            head = head.next
        
        #busca 2o. valor
        index2 = tamanho - k
        head = first.next # voltar pro inicio da lista
        index_busca = 1

        while head and index_busca <= index2:
            #print(f'index_busca: {index_busca}/{index2}, valor1: {valor1}, valor2: {valor2}')

            if (index_busca == index2):
                valor2 = head.val
            head = head.next
            index_busca += 1

        head = first.next # voltar pro inicio da lista

        #troca
        index = 1
        while head:
            #print(f'index: {index}/{index2}, valor1: {valor1}, valor2: {valor2}')
            if (index == k): #1o. elemento
                head.val = valor2
            
            if (index == index2):
                head.val = valor1

            index += 1
            head = head.next

        return first.next

#ONE PASS (COPILOT)

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def swapNodes(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:        
        first = head
        second = head
        current = head

        # Move `first` to the k-th node
        for _ in range(k - 1):
            first = first.next

        # Keep a reference to the k-th node
        kth_from_start = first

        # Move `current` to the end, and `second` to the k-th node from the end
        while current.next:
            current = current.next
            if k > 1:
                k -= 1
            else:
                second = second.next

        # Swap the values of the k-th node from the start and the k-th node from the end
        kth_from_start.val, second.val = second.val, kth_from_start.val

        return head