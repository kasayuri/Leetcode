//https://leetcode.com/problems/isomorphic-strings/

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> hashMap = new Dictionary<char,char>();

        for (int i=0; i<s.Length; i++){
            if (hashMap.ContainsKey(s[i])){
                if (hashMap[s[i]] != t[i])
                    return false;
            }
            else if (hashMap.ContainsValue(t[i]))
                return false;
            
            hashMap[s[i]] = t[i];
        }

        return true;
    }
}
