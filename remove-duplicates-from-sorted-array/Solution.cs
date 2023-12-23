// https://leetcode.com/problems/remove-duplicates-from-sorted-array

public class Solution {
    public int RemoveDuplicates(int[] nums) {
      var curr = 0;
            var taken = -1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    taken = nums[i];
                    curr++;
                }else if (taken < nums[i])
                {
                    nums[curr++] = nums[i];
                    taken = nums[i];
                }
            }

            return curr;
    }
}