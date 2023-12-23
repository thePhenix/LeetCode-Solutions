// https://leetcode.com/problems/merge-strings-alternately

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int word1Len = word1.Length;
        int word2Len = word2.Length;
        int i = 0;
        int j = 0;
        var ans = new StringBuilder();
        while(i < word1Len && j < word2Len){
            ans.Append(word1[i]);
            ans.Append(word2[j]);
            i++;
            j++;
        }

        while(i < word1Len){
            ans.Append(word1[i]);
            i++;
        }

        while(j < word2Len){
            ans.Append(word2[j]);
            j++;
        }

        return ans.ToString();
    }
}