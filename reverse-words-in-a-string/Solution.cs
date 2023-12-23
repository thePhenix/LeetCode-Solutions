// https://leetcode.com/problems/reverse-words-in-a-string

public class Solution {
    public string ReverseWords(string s) {
        var words = s.Trim().Split(" ");
        var ans = new StringBuilder();
        for(var i = words.Length - 1; i>= 0; i--){
            var word = words[i].Trim();
            if(word.Length > 0){
                ans.Append(words[i]);
                if(i != 0){
                    ans.Append(" ");
                }
            }
        }

        return ans.ToString();
    }
}