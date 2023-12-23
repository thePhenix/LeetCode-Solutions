// https://leetcode.com/problems/find-pivot-index

public class Solution {
    public int PivotIndex(int[] nums) {
        var leftSum = 0;
            var rightSum = 0;
            var currentPivot = 0;

            foreach (var t in nums)
            {
                rightSum += t;
            }


            while (currentPivot < nums.Length)
            {
                rightSum -= nums[currentPivot];
                if (leftSum == rightSum)
                {
                    return currentPivot;
                }

                leftSum += nums[currentPivot];
                currentPivot++;
            }

            return -1;
    }
}