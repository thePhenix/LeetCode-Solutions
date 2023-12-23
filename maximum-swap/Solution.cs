// https://leetcode.com/problems/maximum-swap

public class Solution {
    public int MaximumSwap(int num) {
        var str = new StringBuilder(num.ToString());
        var maxValue = -1;
        var maxValueIndex = -1;
        var leftSwapIndex = -1;
        var rightSwapIndex = -1;

        for(var i = str.Length - 1; i >= 0; i--){
            if(str[i] > maxValue){
                maxValue = str[i];
                maxValueIndex = i;
                continue;
            }

            if(str[i] < maxValue){
                leftSwapIndex = i;
                rightSwapIndex = maxValueIndex;
            }
        }

        if(leftSwapIndex >= 0){
            var temp = str[leftSwapIndex];
            str[leftSwapIndex] = str[rightSwapIndex];
            str[rightSwapIndex] = temp;
        }

        return Convert.ToInt32(str.ToString());
    }
}