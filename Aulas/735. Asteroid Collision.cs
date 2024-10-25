// https://leetcode.com/problems/longest-common-subsequence/submissions/1433499687
/*
We are given an array asteroids of integers representing asteroids in a row.

For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left). Each asteroid moves at the same speed.

Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.
*/

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> pilha = new Stack<int>();
        
        for(int i=0; i<asteroids.Length; i++){
            bool destruiu = false;

            //while asteroids n explode e tem coisa na pilha
            while (pilha.Any()
                && asteroids[i] < 0 //direcao de conflito
                && pilha.Peek() > 0)
            {
                //se o que esta na pilha é menor que o que esta vindo
                if (pilha.Peek() < -asteroids[i]){ 
                    pilha.Pop();
                    continue;
                } 
                else if(pilha.Peek() == -asteroids[i]){ //se são iguais
                    pilha.Pop();
                }
                destruiu = true;
                break;
            }

            if (!destruiu){
                pilha.Push(asteroids[i]);
            }
        }
        
        
        //return stack.Reverse().ToArray();

        //percorrer a stack para preencher o array na ordem certa
        int[] result = new int[pilha.Count];
    
        for(int i =  pilha.Count-1; i >= 0; i--){
            Console.WriteLine(pilha.Peek());
            result[i] = pilha.Pop();
        }

        return result;
    }
}
