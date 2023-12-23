// https://leetcode.com/problems/3sum

public class Solution {
    
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> ans = new List<IList<int>>();
        var set = new HashSet<int>();
        var tempSet = new HashSet<string>();
        for(var i = 0; i < nums.Length; i++){
            for (var j=i+1; j< nums.Length; j++){
                var req = -(nums[i] + nums[j]);
                if(set.Contains(req)){
                    var triplet = new List<int>(){nums[i], nums[j], req};
                    triplet.Sort();
                    var tripletString = string.Join(",", triplet);
                    if(tempSet.Add(tripletString)){
                        ans.Add(triplet);
                    }
                }
                else{
                    set.Add(nums[j]);
                }
            }
            set.Clear();
        }
        return ans;
    }
}