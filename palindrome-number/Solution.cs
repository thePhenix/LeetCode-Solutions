// https://leetcode.com/problems/palindrome-number

public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0){
            return false;
        }
        
        int reverse = 0;
        int initNumber = x;
        while(x != 0){
            reverse = (reverse * 10) + (x%10);
            x = x/10;
        }

        return initNumber == reverse;
    }
}