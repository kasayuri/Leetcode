// https://leetcode.com/problems/longest-common-subsequence/description/
/*
Given two strings text1 and text2, return the length of their longest common subsequence. If there is no common subsequence, return 0.

A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

    For example, "ace" is a subsequence of "abcde".

A common subsequence of two strings is a subsequence that is common to both strings.
*/


public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int[,] memo = new int[text1.Length + 1, text2.Length + 1];
        for (int i = 0; i <= text1.Length; i++) {
            for (int j = 0; j <= text2.Length; j++) {
                memo[i, j] = -1;
            }
        }
        return lcs(text1, text2, 0, 0, memo);
    }

    public int lcs(string text1, string text2, int idx1, int idx2, int[,] memo) {
        if (idx1 == text1.Length) {
            return 0;
        }
        if (idx2 == text2.Length) {
            return 0;
        }
        if (memo[idx1,idx2] != -1) {
            return memo[idx1,idx2];
        }
        if (text1[idx1] == text2[idx2]){
            return memo[idx1,idx2] = 1 + lcs(text1, text2, idx1 + 1, idx2 + 1, memo);
        }

        int possibility1 = lcs(text1, text2, idx1 + 1, idx2, memo);
        int possibility2 = lcs(text1, text2, idx1, idx2 + 1, memo);

        return memo[idx1,idx2] = Math.Max(possibility1, possibility2);
    }

}
