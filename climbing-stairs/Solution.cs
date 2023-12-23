// https://leetcode.com/problems/climbing-stairs

public class Solution {
    public int ClimbStairs(int n) {
        int count = 0;
        var list = new int[n + 1];
        list[0] = 1;
        list[1] = 1;
        
        for(var i = 2; i <= n; i++){
            list[i] = list[i-1] + list[i-2];
        }
        
        return list[n];
    }
}