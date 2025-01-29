# https://leetcode.com/problems/add-two-numbers/

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        # pode acontecer de ter uma lista maior que a outra
        # somar por posicao. Caso adicionar + 1 dígito, somar no next

        head = ListNode(0)
        curr = head
        decimal, ultimo_digito = 0, 0

        while(l1 != None or l2 != None or decimal != 0):
            head.next = ultimo_digito

            valor1 = l1.val if l1 else 0
            valor2 = l2.val if l2 else 0

            soma = valor1 + valor2 + decimal

            decimal = soma // 10
            ultimo_digito = soma % 10

            novo = ListNode(ultimo_digito)
            curr.next = novo
            curr = novo

            print(f'{decimal}, {ultimo_digito}')

            l1 = l1.next if l1 else None
            l2 = l2.next if l2 else None

        return head.next
