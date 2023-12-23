// https://leetcode.com/problems/longest-consecutive-sequence

public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        HashSet<int> set = new HashSet<int>(nums);
        
        int max = 0;
        foreach(var num in nums)
        {
            if(!set.Contains(num - 1))
            {
                int start = num;
                int len = 1;
                while(set.Contains(start + 1))
                {
                    len++;
                    start++;
                }
                    
                max = Math.Max(max, len);
            }
        }
        
        return max;
    }
}