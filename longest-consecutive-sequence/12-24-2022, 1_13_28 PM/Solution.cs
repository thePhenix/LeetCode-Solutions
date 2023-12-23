// https://leetcode.com/problems/longest-consecutive-sequence

public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Count() == 0){
            return 0;
        }
        
        Array.Sort(nums);
        var maxLength = 1;
        var counter = 1;

        for(var i = 1; i < nums.Count(); i++) {
            if(nums[i] == nums[i-1] + 1) {
                counter++;
                if(counter > maxLength){
                    maxLength = counter;
                }
            }
            else if(nums[i] == nums[i-1]){
                continue;
            }
            else
            {
                counter = 1;
            }
        }

        return maxLength;
    }

}