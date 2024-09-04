// https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/description/

//O(N) - s1 e s1 têm o mesmo tamanho

public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        char diffArray1 = '0';
        char diffArray2 = '0';
        int countDiff = 0;

        //percorre caractere a caractere e compara se iguais. 
        //Se n for, armazena em uma var diff
        for(int i = 0; i < s1.Length; i++){
            if (s1[i] != s2[i]){
                countDiff++;
                if (diffArray1 == '0'){
                    diffArray1 = s1[i];
                    diffArray2 = s2[i];
                } //chars sao diferentes e tem algo no diff
                else if (diffArray1 != s2[i] || diffArray2 != s1[i]){
                    return false;
                }
            }
        }

        //se as duas forem iguais
        if (diffArray1 == '0' && diffArray2 == '0') 
            return true;

        // verifica se houve exatamente 2 chars diferentes
        if (countDiff != 2)
            return false;

        return true;
    }
}
