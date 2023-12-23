// https://leetcode.com/problems/single-number

public class Solution {
    public int SingleNumber(int[] nums) {
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            }else{
                dict[nums[i]] = 1;
            }
        }
        
        foreach(var item in dict){
            if(item.Value == 1){
                return item.Key;
            }
        }
        
        return nums[0];
    }
}