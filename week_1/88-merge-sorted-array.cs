//https://leetcode.com/problems/merge-sorted-array/description/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (m == 0){
            Array.Copy(nums2, nums1, n);
            return;
        }

        int[] numsAux = new int[m];
        Array.Copy(nums1, numsAux, m);
        int index1 = 0;
        int index2 = 0;

        for(int i = 0; i < n+m; i++){
            if (index2 >= n || (index1 < m && numsAux[index1] < nums2[index2])) {
                nums1[i] = numsAux[index1];
                index1++;
            } else {
                nums1[i] = nums2[index2];
                index2++;
            } 
            Console.WriteLine($"{nums1}");
        }
    }

}
