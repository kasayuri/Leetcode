# https://leetcode.com/problems/binary-tree-postorder-traversal/description/
'''
Given the root of a binary tree, return the postorder traversal of its nodes' values.

Example 1:
Input: root = [1,null,2,3]
Output: [3,2,1]

Example 2:
Input: root = [1,2,3,4,5,null,8,null,null,6,7,9]
Output: [4,6,7,5,2,9,8,3,1]

Example 3:
Input: root = []
Output: []

Example 4:
Input: root = [1]
Output: [1]
'''

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def postorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        result = []

        if not root:
            return result

        result = self.postorderTraversalRecursive(root, result)

        return result

    def postorderTraversalRecursive(self, root:[TreeNode], result:[int]) -> List[int]:
        if not root:
            return
        print(root.val)

        self.postorderTraversalRecursive(root.left, result)
        self.postorderTraversalRecursive(root.right, result)
        result.append(root.val)

        return result

# Time complexity: O(n)
# Space complexity: O(n)

# Melhorado: 
class Solution:
    def postorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        return self.postorderTraversalRecursive(root, [])

    def postorderTraversalRecursive(self, root:[TreeNode], result:[int]) -> List[int]:
        if root:
            self.postorderTraversalRecursive(root.left, result)
            self.postorderTraversalRecursive(root.right, result)
            result.append(root.val)

        return result
