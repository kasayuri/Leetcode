# https://leetcode.com/problems/same-tree/description/?envType=problem-list-v2&envId=binary-tree

'''
Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

Example 1:
Input: p = [1,2,3], q = [1,2,3]
Output: true

Example 2:
Input: p = [1,2], q = [1,null,2]
Output: false

Example 3:
Input: p = [1,2,1], q = [1,1,2]
Output: false
 
Constraints:

The number of nodes in both trees is in the range [0, 100].
-104 <= Node.val <= 104
'''

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        if (p == None and q == None):
            return True

        if (p and not q) or (q and not p) or (p.val != q.val):
            return False

        if not p.left and not p.right and not q.left and not q.right:
            return True
        
        return self.isSameTree(p.left, q.left) and self.isSameTree(p.right, q.right)
    

# Time complexity: O(n)
# Space complexity: O(n)
# where n is the number of nodes in the tree

# Solução do editorial:

class Solution:
    def isSameTree(self, p: TreeNode, q: TreeNode) -> bool:
        # p and q are both None
        if not p and not q:
            return True
        # one of p and q is None
        if not q or not p:
            return False
        if p.val != q.val:
            return False
        return self.isSameTree(p.right, q.right) and self.isSameTree(
            p.left, q.left
        )