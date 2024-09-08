public class Solution {
    public string ToLowerCase(string s) {
        char[] result = s.ToCharArray();
        for (int i = 0; i < s.Length; i++){
            if (result[i] >= 'A' && result[i] <= 'Z') {
                result[i] = (char)(result[i] + 32); // Convert uppercase to lowercase
            } 
        }
        return new string(result);
    }
}
