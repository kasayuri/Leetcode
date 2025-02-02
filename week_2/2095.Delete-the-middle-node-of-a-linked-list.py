# https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/description/

'''
You are given the head of a linked list. Delete the middle node, and return the head of the modified linked 
list.

The middle node of a linked list of size n is the ⌊n / 2⌋th node from the start using 0-based indexing, 
where ⌊x⌋ denotes the largest integer less than or equal to x.

For n = 1, 2, 3, 4, and 5, the middle nodes are 0, 1, 1, 2, and 2, respectively.
'''

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

# O(n)
# O(1)

class Solution:
    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:
        slow = fast = prev = head
        if not head.next:
            return None

        while(fast and fast.next):
            prev = slow
            slow = slow.next
            fast = fast.next.next
        
        # anterior = prev
        # meio = slow
        # prox = slow.next

        prev.next = slow.next
        return head

# Editorial
# Muito parecido com o que eu fiz, só não criou uma variável prev.
# Para conseguir o valor anterior, o fast andou primeiro


'''
class Solution:
    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:   
        # Edge case: return None if there is only one node.
        if head.next == None:
            return None
        
        # Initialize two pointers, 'slow' and 'fast'.
        slow, fast = head, head.next.next
        
        # Let 'fast' move forward by 2 nodes, 'slow' move forward by 1 node each step.
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next
        
        # When 'fast' reaches the end, remove the next node of 'slow' and return 'head'.
        slow.next = slow.next.next
        
        # The job is done, return 'head'.
        return head
'''
