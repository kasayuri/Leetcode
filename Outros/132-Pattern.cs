Mock 132
Given an array of n integers nums, a 132 pattern is a subsequence of three integers nums[i], nums[j] and nums[k] such that i < j < k and nums[i] < nums[k] < nums[j].

Return true if there is a 132 pattern in nums, otherwise, return false.

[5.6.7.10,9,1,6] => 5,10,6
[3,9,14,0,2,1]

//buscar o maior valor
stack pilha 2 1
var menorValorPilha 1

---------------------------------------------------------------
i < j < k 
nums[i] < nums[k] < nums[j]
array pode ser vazio
10ˆ5 elementos
retorna true caso encontre pelo menos 1
---------------------------------------------------------------


[5.6.7.10,9,1,6] => 5,10,6

public bool SeguePadrao(int[] nums){         //[5.6.7.10,9,1,6] 
    Stack<int> pilha = new Stack<int>();

    pilha.Add(nums[nums.Length]);        //[10, 9, 6]
    int menorValorPilha = nums[nums.Length];     //[6]
int count = 1;                     // 3

    for (int i = nums.Length-1; i <= 0; i--){         //[5.6.7.10,9,1]
        if (nums[i] > pilha.Peek()){
            pilha.Push(nums[i]);
            count++;
} else //buscar pelo menor valor
{     // verificar se tem 2 elem na pilha e comparar o valor com a variavel aux. Se for menor, retorna true

            if (count >= 2 && nums[i] < menorValorPilha)
                return true;
        }
}

    return false;
}




-- Add mais exemplos
