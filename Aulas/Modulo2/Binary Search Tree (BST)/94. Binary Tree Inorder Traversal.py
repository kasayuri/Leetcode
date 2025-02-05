# https://leetcode.com/problems/binary-tree-inorder-traversal/description/
# easy
'''
Given the root of a binary tree, return the inorder traversal of its nodes' values.

Example 1:
Input: root = [1,null,2,3]
Output: [1,3,2]

Example 2:
Input: root = [1,2,3,4,5,null,8,null,null,6,7,9]
Output: [4,2,6,5,7,1,3,9,8]

'''

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        # in order = left, root, right

        result = []
        self.inorderTraversalRecursive(root, result)
        return result


    def inorderTraversalRecursive(self, root: Optional[TreeNode], result:Optional[TreeNode]) -> List[int]:
        
        if root:
            self.inorderTraversalRecursive(root.left, result)
            result.append(root.val)
            self.inorderTraversalRecursive(root.right, result)


# Time complexity: O(n)
# Space complexity: O(n)
# Where n is the number of nodes in the tree.


# outra solução, usando stack:

class Solution:
    def inorderTraversal(self, root):
        res = []
        stack = []
        curr = root
        while curr or stack:
            while curr:
                stack.append(curr)
                curr = curr.left
            curr = stack.pop()
            res.append(curr.val)
            curr = curr.right
        return res
    
# Time complexity: O(n)
# Space complexity: O(n)

# Existe ainda outra solução, usando Morris Traversal, que é O(1) de espaço, mas O(n) de tempo. - 
# https://stackoverflow.com/questions/5502916/explain-morris-inorder-tree-traversal-without-using-stacks-or-recursion