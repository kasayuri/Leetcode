//https://leetcode.com/problems/majority-element/
/*
Given an array nums of size n, return the majority element.
The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109

*/

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> hashSet  = new Dictionary<int,int>();

        foreach (int num in nums){
            if (hashSet.ContainsKey(num)){
                hashSet[num] +=1;
                if (hashSet[num] > nums.Length/2)
                    return num;
            } else {
                hashSet.Add(num,1);
            }
        }

        return nums[0];
    }
}
