// https://leetcode.com/problems/robot-return-to-origin

public class Solution {
    public bool JudgeCircle(string moves) {
        int up = 0;
        int down = 0;
        int left = 0;
        int right = 0;

        for(var i = 0; i < moves.Length; i++){
            var dir = moves[i];
            if(dir == 'U'){
                up++;
            }
            else if(dir == 'D'){
                down++;
            }
            else if(dir == 'L'){
                left++;
            }
            else if(dir == 'R'){
                right++;
            }
        }

        return (left == right) && (up == down);
    }
}