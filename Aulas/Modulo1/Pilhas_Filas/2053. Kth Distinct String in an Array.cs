//https://leetcode.com/problems/kth-distinct-string-in-an-array/submissions/1433599787

/*
Solução usando pilha: precisamos descobrir quais strings são distintas no array de entrada. Criamos um dicionário (<string,int>) para armazenar as frequências das palavras.
Depois percorremos o array de entrada e quando encontramos uma string distinta (i.e., string cujo valor no dicionário de frequência seja 1) adicionamos na pilha. 
Quando o tamanho da pilha for igual a k, retornamos o topo da pilha.
Se o tamanho da pilha nunca for igual à k, retornamos uma string vazia.
*/

public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string, int> freq = new Dictionary<string, int>();
        Stack<string> stack = new Stack<string>();
        foreach (string str in arr) {
            if (!freq.ContainsKey(str)) {
                freq[str] = 0;
            }
            freq[str]++;
        }

        foreach (string str in arr) {
            if (freq[str] == 1) {
                stack.Push(str);
                if (stack.Count == k) {
                    return stack.Peek();
                }
            }
        }
        return string.Empty;
    }
}
