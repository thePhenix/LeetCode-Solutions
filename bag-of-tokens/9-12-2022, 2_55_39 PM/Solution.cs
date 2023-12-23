// https://leetcode.com/problems/bag-of-tokens

public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        tokens = tokens.OrderBy(z => z).ToArray();
        int score = 0;
        int j = tokens.Length - 1;
        for(var i = 0; i < tokens.Length; i++){
            if(tokens[i] <= power){
                power -= tokens[i];
                score++;
            }else if(score >= 1 && i != j){
                power += tokens[j] - tokens[i];
                j--;
            }else{
                break;
            }
        }
        
        return score;
    }
}