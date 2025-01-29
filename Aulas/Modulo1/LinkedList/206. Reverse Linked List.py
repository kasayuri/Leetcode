# https://leetcode.com/problems/reverse-linked-list/

#recursivo

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        return self.reverseListRecursive(head)

    def reverseListRecursive(self, atual: ListNode) -> ListNode:
        if (not atual) or (not atual.next):
            return atual
        
        novo_node = self.reverseListRecursive(atual.next) 
        atual.next.next = atual #sentido antigo, deve ser invertido 
        atual.next = None
        return novo_node
    

#iterativo

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        prev = None
        atual = head
        
        while atual:
            aux = atual.next
            atual.next = prev
            prev = atual
            atual = aux

        return prev