// https://leetcode.com/problems/happy-number

public class Solution {
    public bool IsHappy(int n) {
        var set = new HashSet<int>();
        while(n != 1){
            var x = n;
            var sum = 0;
            while(x > 0){
                var y = x%10;
                sum += y * y;
                x = x / 10;
            }
            n = sum;
            if(!set.Add(n)){
                return false;
            }
        }
        return true;
    }
}