//https://leetcode.com/problems/longest-substring-without-repeating-characters/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hash = new HashSet<char>();
        int maior = 0;
        int total = 0;

        for(int i=0; i<s.Length; i++){
            if (!hash.Add(s[i])){
                maior = Math.Max(total, maior);
                hash.Clear();
                hash.Add(s[i]);
                total=0;
            }

            total++;
        }

        return Math.Max(total, maior);
    }
}
