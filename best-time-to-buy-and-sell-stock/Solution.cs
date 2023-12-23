// https://leetcode.com/problems/best-time-to-buy-and-sell-stock

public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = int.MinValue;
        var lowestPrice = prices[0];
        
        for(var i=0;i<prices.Length; i++){
            lowestPrice = Math.Min(lowestPrice, prices[i]);
            if(prices[i] > lowestPrice){
                var currentProfit = prices[i] - lowestPrice;
                maxProfit = Math.Max(maxProfit, currentProfit);
            }
        }
        
        if(maxProfit < 0){
            return 0;
        }
        
        return maxProfit;
    }
}