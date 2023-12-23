// https://leetcode.com/problems/running-sum-of-1d-array

public class Solution {
    public int[] RunningSum(int[] nums) {
        var result = new int[nums.Count()];
        var sum = 0;
        for(var i= 0; i< nums.Count(); i++){
            sum += nums[i];
            result[i] = sum;
        }
        
        return result;
    }
}