public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
 
        foreach (int i in nums){
            if (!set.Add(i)){
                return true;
            }
        }
        return false;
    }
}
