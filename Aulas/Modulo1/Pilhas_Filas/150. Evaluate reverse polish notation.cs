//https://leetcode.com/problems/evaluate-reverse-polish-notation/

/*
You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.

Evaluate the expression. Return an integer that represents the value of the expression.

Note that:

    The valid operators are '+', '-', '*', and '/'.
    Each operand may be an integer or another expression.
    The division between two integers always truncates toward zero.
    There will not be any division by zero.
    The input represents a valid arithmetic expression in a reverse polish notation.
    The answer and all the intermediate calculations can be represented in a 32-bit integer.

*/

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
