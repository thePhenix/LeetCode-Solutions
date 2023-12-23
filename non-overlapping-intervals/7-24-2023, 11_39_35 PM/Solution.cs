// https://leetcode.com/problems/non-overlapping-intervals

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        var sorted = intervals.OrderBy(x => x[0]).ThenBy(y => y[1]).ToList();
            var max = sorted[0][1];
            int count = 0;
            for (var i = 1; i < sorted.Count(); i++)
            {
                if (sorted[i][0] < max)
                {
                    count++;
                    if (sorted[i][1] < max)
                    {
                        max = sorted[i][1];
                    }
                }
                else
                {
                    max = sorted[i][1];
                }
            }

            return count;
    }
}