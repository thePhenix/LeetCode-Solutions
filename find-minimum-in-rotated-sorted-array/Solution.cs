// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array

public class Solution {
    public int FindMin(int[] nums) {
        int len = nums.Length;
        int start = 0;
        int end = len - 1;
        int min = int.MaxValue;
        while(start <= end){
            int mid = (start + end) / 2;
            if(nums[start] <= nums[mid]){
                min = Math.Min(min, nums[start]);
                start = mid + 1;
            }
            else
            {
                min = Math.Min(min, nums[mid]);
                end = mid - 1;
            }
        }

        return min;
    }
}