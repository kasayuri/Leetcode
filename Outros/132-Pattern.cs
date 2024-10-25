// https://leetcode.com/problems/132-pattern/submissions/1433526253
/*
Given an array of n integers nums, a 132 pattern is a subsequence of three integers nums[i], nums[j] and nums[k] such that i < j < k and nums[i] < nums[k] < nums[j].

Return true if there is a 132 pattern in nums, otherwise, return false.
*/
public class Solution {
    public bool Find132pattern(int[] nums) {

        Stack<int> pilha = new Stack<int>();

        pilha.Push(nums[nums.Length-1]);        //[10, 9, 6]
        int menorValorPilha = nums[nums.Length-1];     //[6]
        int count = 1;                     // 3

        for (int i = nums.Length-2; i>=0; i--){         //[5.6.7.10,9,1]
            //buscar pelo menor valor
            // verificar se tem 2 elem na pilha e comparar o valor com a variavel aux. Se for menor, retorna true
            if (count >= 2 && nums[i] < menorValorPilha)
                return true;

            while (pilha.Any() && nums[i] > pilha.Peek()){
                menorValorPilha = pilha.Pop();
                count++;
            }
          
            pilha.Push(nums[i]);
        }

        return false;

    }
}
