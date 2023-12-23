// https://leetcode.com/problems/3sum

public class Solution {
    
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> ans = new List<IList<int>>();
        Array.Sort(nums);
        for(var i = 0; i<nums.Length; i++){
            var j = i + 1;
            var k = nums.Length - 1;
            if(i > 0 && nums[i] == nums[i-1]){
                continue;
            }

            while(j<k){
                var sum = nums[i] + nums[j] + nums[k];
                if(sum == 0){
                    ans.Add(new List<int>(){nums[i], nums[j], nums[k]});
                    j++;
                    k--;
                    while(j < k && nums[j] == nums[j-1]){
                        j++;
                    }
                    while(j < k && k < nums.Length - 1 && nums[k] == nums[k + 1]){
                        k--;
                    }
                }else if(sum > 0){
                    k--;
                }else {
                    j++;
                }
            }
        }
        return ans;
    }
}