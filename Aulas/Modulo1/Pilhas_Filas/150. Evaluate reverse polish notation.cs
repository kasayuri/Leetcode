//https://leetcode.com/problems/evaluate-reverse-polish-notation/

/*
Estratégia: percorrer o array de tokens empilhando os operandos.
Quando encontrar um operador, retira os dois últimos operandos da pilha e realiza a operação, empilhando o resultado.
Como a entrada é garantida ser uma expressão válida, ao final das operações a pilha conterá um único valor, que é a avaliação da expressão de entrada.
*/

public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> pilha = new Stack<int>();

        foreach (string token in tokens) 
        {
            if (!"+-*/".Contains(token)) 
            {
                pilha.Push(Int32.Parse(token));
                continue;
            }

            int var1 = pilha.Pop();
            int var2 = pilha.Pop();
            char op = Char.Parse(token);

            pilha.Push(CalculaOperacao(var1, var2, op));
        }

        return pilha.Pop();
    }

    private int CalculaOperacao(int valor1, int valor2, char operador){
        if (operador == '+'){
            return valor2 + valor1;
        } else if (operador == '-'){
            return valor2 - valor1;
        } else if (operador == '*'){
            return valor2 * valor1;
        } else if (operador == '/'){
            return valor2/valor1;
        } else{
            return 0;
        }

    }
}
