//https://leetcode.com/problems/evaluate-reverse-polish-notation/

/*
Estratégia: percorrer o array de tokens empilhando os operandos.
Quando encontrar um operador, retira os dois últimos operandos da pilha e realiza a operação, empilhando o resultado.
Como a entrada é garantida ser uma expressão válida, ao final das operações a pilha conterá um único valor, que é a avaliação da expressão de entrada.
*/

