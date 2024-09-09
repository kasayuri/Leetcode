//https://leetcode.com/problems/two-sum/description/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
		
		for (int i=0; i<nums.Length; i++)
		{
			int valor = target - nums[i];
			if (dict.ContainsKey(valor))
				return new int[]{i, dict[valor]};

			dict.TryAdd(nums[i],i);
		}

		return null;
    }
}
