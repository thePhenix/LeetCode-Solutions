// https://leetcode.com/problems/remove-covered-intervals

public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        var overlap = 0;
            var length = intervals.Length;
            for (var i = 0; i < intervals.Length; i++)
            {
                for (var j = 0; j < intervals.Length; j++)
                {
                    if (i != j && intervals[i][0] >= intervals[j][0] && intervals[i][1] <= intervals[j][1])
                    {
                        overlap++;
                        break;
                    }
                }
            }
        
        return length - overlap;
    }
}