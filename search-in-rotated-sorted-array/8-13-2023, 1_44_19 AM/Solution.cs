// https://leetcode.com/problems/search-in-rotated-sorted-array

public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;
        int min = int.MaxValue;
        int pivot = -1;

        while(low <= high){
            int mid = (low + high) / 2;
            if(nums[low] <= nums[mid]){
                if(nums[low] < min){
                    min = nums[low];
                    pivot = low;
                }
                low = mid + 1;
            }
            else{
                if(nums[mid] < min){
                    min = nums[mid];
                    pivot = mid;
                }
                high = mid - 1;
            }
        }
        
        if(nums[nums.Length - 1] < target){
            low = 0;
            high = pivot - 1;
        }else {
            low = pivot;
            high = nums.Length - 1;
        }
        
        while(low <= high){
            int mid = (low + high) / 2;
            if(nums[mid] == target){
                return mid;
            }else if(nums[mid] > target){
                high = mid - 1;
            }else{
                low = mid + 1;
            }
        }

        return -1;
    }
}