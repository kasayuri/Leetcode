// https://leetcode.com/problems/longest-common-prefix/submissions/1436701146/
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //["flower","flow","flight"]
        int qtdStrings = strs.Length;
        string resultado = string.Empty;
        int min = 9999;

        if (qtdStrings == 1 )
            return strs[0];

        // buscar pelo maior array
        foreach(string s in strs){
            min = Math.Min(s.Length, min);
        }

        //percorrer a string - flower
        string primeiraPalavra = strs[0];
        int m = 0;
        while ( m < min ){
            char c = primeiraPalavra[m];
            int count = 1;

            for(int i=1; i< qtdStrings; i++){ 
                if (c != strs[i][m]) // l 
                    break;
                count++;
            }

            if (count == qtdStrings){
                resultado += c.ToString();
            } else {
                return resultado;
            }

            m++;
        }

        return resultado;
    }
}
