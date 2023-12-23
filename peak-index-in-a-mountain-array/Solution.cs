// https://leetcode.com/problems/peak-index-in-a-mountain-array

public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int max = int.MinValue;
        int position = -1;
        for(var i =0; i< arr.Length; i++){
            if(arr[i] > max){
                max = arr[i];
                position = i;
            }
        }

        return position;
    }
}