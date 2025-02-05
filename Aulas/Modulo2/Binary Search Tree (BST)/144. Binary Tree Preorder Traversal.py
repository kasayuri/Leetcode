# https://leetcode.com/problems/binary-tree-preorder-traversal/

'''
Given the root of a binary tree, return the preorder traversal of its nodes' values.

Example 1:
Input: root = [1,null,2,3]
Output: [1,2,3]

'''

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        return self.preorderTraversalRecursive(root, [])
    
    def preorderTraversalRecursive(self, root:[TreeNode], result:[]) -> List[int]:
        if root:
            result.append(root.val)
            self.preorderTraversalRecursive(root.left, result)
            self.preorderTraversalRecursive(root.right, result)

        return result
