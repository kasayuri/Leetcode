# https://leetcode.com/problems/search-in-a-binary-search-tree/

'''
You are given the root of a binary search tree (BST) and an integer val.

Find the node in the BST that the node's value equals val and return the subtree rooted with that node.
If such a node does not exist, return null.

Example 1:

Input: root = [4,2,7,1,3], val = 2
Output: [2,1,3]

Example 2:

Input: root = [4,2,7,1,3], val = 5
Output: []

'''

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def searchBST(self, root: Optional[TreeNode], val: int) -> Optional[TreeNode]:
        
        # [4,2,7,1,3]  val = 2
        while(root != None):
            if (root.val > val):
                return self.searchBST(root.left, val)
            elif (root.val < val):
                return self.searchBST(root.right, val)
            else:
                return root
        return None