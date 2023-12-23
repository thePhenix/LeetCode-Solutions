// https://leetcode.com/problems/determine-if-two-events-have-conflict

public class Solution {
    public bool HaveConflict(string[] event1, string[] event2) {
        var evt1Start = event1[0].Split(":");
        var evt1End = event1[1].Split(":");
        var evt1StartTime = (int.Parse(evt1Start[0]) * 60) + int.Parse(evt1Start[1]);
        var evt1EndTime = (int.Parse(evt1End[0]) * 60) + int.Parse(evt1End[1]);

        var evt2Start = event2[0].Split(":");
        var evt2End = event2[1].Split(":");

        var evt2StartTime = (int.Parse(evt2Start[0]) * 60) + int.Parse(evt2Start[1]);
        var evt2EndTime = (int.Parse(evt2End[0]) * 60) + int.Parse(evt2End[1]);

        return evt2StartTime <= evt1EndTime && evt2EndTime >= evt1StartTime;
    }
}