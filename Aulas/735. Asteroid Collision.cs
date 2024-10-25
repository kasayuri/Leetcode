// https://leetcode.com/problems/longest-common-subsequence/submissions/1433499687

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