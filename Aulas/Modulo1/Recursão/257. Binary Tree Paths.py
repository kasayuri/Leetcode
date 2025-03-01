# https://leetcode.com/problems/binary-tree-paths/

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def binaryTreePaths(self, root: Optional[TreeNode]) -> List[str]:

        def binaryTreePathsRecursive(root, caminho):
            if (root):
                caminho.append(str(root.val))
                if (not root.left and not root.right):
                    output.append('->'.join(caminho))
                else:
                    binaryTreePathsRecursive(root.left, caminho)
                    binaryTreePathsRecursive(root.right, caminho)
                caminho.pop()
        output = []
        binaryTreePathsRecursive(root, [])
        return output



    
