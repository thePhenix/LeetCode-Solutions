// https://leetcode.com/problems/two-sum

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[2];

            for (var i = 0; i < nums.Length - 1; i++)
            {
                var current = nums[i];
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (current + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }

            return result;
    }
}