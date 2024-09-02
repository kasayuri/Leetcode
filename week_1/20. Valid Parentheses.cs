/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 
Example 1:

Input: s = "()"
Output: true

Example 2:

Input: s = "()[]{}"
Output: true

Example 3:

Input: s = "(]"
Output: false

Example 4:

Input: s = "([])"
Output: true

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
*/


public class Solution {
    public bool IsValid(string s) {
        char[] inicio = new char[]{'(','{','['};
        char[] fim = new char[]{')','}',']'};
        
        Stack<char> pilha = new Stack<char>();

        //se inicio, add na pilha. se fim, ver se fecha o par do 1o item da pilha
        foreach (char c in s.ToCharArray()){
            if (inicio.Contains(c)){
                pilha.Push(c);
            } else if (fim.Contains(c)){
                int position = Array.IndexOf(fim, c);
                
                //Se começar com um de fechar ou não fechar o que está aberto
                if (pilha.Count == 0 || pilha.Peek() != inicio[position])
                    return false;

                pilha.Pop();
            }
        }

        //Verifica se algum char ficou sem fechar
        if (pilha.Count > 0)
            return false;

        return true;
    }
}