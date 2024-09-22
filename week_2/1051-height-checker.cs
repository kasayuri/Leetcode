//https://leetcode.com/problems/height-checker/description/
/*
A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.

You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).

Return the number of indices where heights[i] != expected[i].
*/

public class Solution {
    public int HeightChecker(int[] heights) {
        int[] expected = new int[heights.Length];
        Array.Copy(heights, expected, heights.Length);
        CountingSort(expected);
        // expected é heights ordenado ASC
        // comparar expected com heights
        // retornar count de elementos diferentes

        //Comparar
        int count = 0;
        for (int i = 0; i < heights.Length; i++){
            if (expected[i] != heights[i]){
                count++;
            }
        }
        return count;
    }
    
    private void CountingSort(int[] arr) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int min = arr[0], max = arr[0];
        
        foreach (int val in arr) {
            if (val < min) 
                min = val;

            if (val > max) 
                max = val;

            if (!counts.ContainsKey(val))
                counts[val] = 0;

            counts[val]++;
        }

        int index = 0;
        
        for (int val = min; val <= max; val++) {
            while (counts.ContainsKey(val) && counts[val] > 0) {
                arr[index] = val;
                index++;
                counts[val]--;
            }
        }
    }
}
