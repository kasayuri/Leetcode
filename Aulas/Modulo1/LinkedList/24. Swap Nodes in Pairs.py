# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def swapPairs(self, head: Optional[ListNode]) -> Optional[ListNode]:
        # armazenar o primeiro elemento para retornar no final
        # se node n for nulo, e nem o proximo, swap

        first = ListNode(0, head)
        prev = first
        
        while head and head.next:
            # swap
            value1 = head
            value2 = head.next
            #print(f'Value2 {value2}')

            prev.next = value2
            value1.next = value2.next
            value2.next = value1

            prev = value1
            head = value1.next
            print(head)
            
        return first.next