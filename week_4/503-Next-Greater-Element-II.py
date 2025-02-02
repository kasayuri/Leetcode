# https://leetcode.com/problems/next-greater-element-ii/description/
'''
Given a circular integer array nums (i.e., the next element of nums[nums.length - 1] is nums[0]), 
return the next greater number for every element in nums.

The next greater number of a number x is the first greater number to its traversing-order next in the array, 
which means you could search circularly to find its next greater number. 
If it doesn't exist, return -1 for this number.


Example 1:

Input: nums = [1,2,1]
Output: [2,-1,2]
Explanation: The first 1's next greater number is 2; 
The number 2 can't find next greater number. 
The second 1's next greater number needs to search circularly, which is also 2.
Example 2:

Input: nums = [1,2,3,4,3]
Output: [2,3,4,-1,4]

'''

# O(n^2)
# O(n)
# Brute force
class Solution:
    def nextGreaterElements(self, nums: List[int]) -> List[int]:
        result = []
        aux_nums = nums + nums
        tamanho = len(nums)

        for i in range(len(nums)):
            #busca próximo num maior
            n = self.busca_proximo(aux_nums[i:i + tamanho])
            result.append(n)

        return result

    def busca_proximo(self, aux_nums: List[int]) -> int:
        print(aux_nums)
        for num in aux_nums[1:]:
            if num > aux_nums[0]:
                return num
        return -1
    



# Solução otimizada (Editorial) - pilha (monotonic stack)
def next_greater_elements(nums):
    res = [-1] * len(nums)
    stack = []
    for i in range(2 * len(nums) - 1, -1, -1):
        while stack and nums[stack[-1]] <= nums[i % len(nums)]:
            stack.pop()
        res[i % len(nums)] = -1 if not stack else nums[stack[-1]]
        stack.append(i % len(nums))
    return res