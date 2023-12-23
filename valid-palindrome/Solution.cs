// https://leetcode.com/problems/valid-palindrome

public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        string str = "";
        foreach(var c in s){
            if((c >= 'a' && c <= 'z') || (c >= '0' && c<='9')){
                str +=c;
            }
        }
        
        var start = 0;
        var end = str.Length - 1;
        
        while(start < end){
            if(str[start++] != str[end--]){
                return false;
            }
        }
        
        return true;
    }
}