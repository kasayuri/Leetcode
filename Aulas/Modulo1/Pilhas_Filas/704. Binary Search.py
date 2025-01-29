# https://leetcode.com/problems/binary-search/description/

class Solution:
    def search(self, nums: List[int], target: int) -> int:
        tamanho = len(nums)
        print(nums)
        if (len(nums) == 1):
            return -1 if target != nums[0] else nums[0]

        if (target < nums[tamanho//2]):
            self.search(nums[0:tamanho//2], target)
        else:
            self.search(nums[tamanho//2:tamanho], target)