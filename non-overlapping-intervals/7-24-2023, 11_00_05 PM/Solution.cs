// https://leetcode.com/problems/non-overlapping-intervals

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        var sorted = intervals.OrderBy(x => x[0]).ThenBy(y => y[1]).ToList();
            var min = sorted[0][0];
            var max = sorted[0][1];
            int count = 0;
            for (var i = 1; i < sorted.Count(); i++)
            {
                if (sorted[i][0] < max)
                {
                    count++;
                    if (sorted[i][1] < max)
                    {
                        min = sorted[i][0];
                        max = sorted[i][1];
                    }
                }
                else
                {
                    min = sorted[i][0];
                    max = sorted[i][1];
                }
            }

            return count;
    }
}