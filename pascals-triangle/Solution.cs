// https://leetcode.com/problems/pascals-triangle

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var list = new int[numRows][];
        list[0] = new int[1] { 1 };
        
        if(numRows > 1){
            list[1] = new int[2] { 1, 1 };
        }
        
        for(var i = 2; i < numRows; i++){
            var li = new int[i+1];
            li[0] = 1;
            li[i] = 1;
            list[i] = li;
            
            for(var j = 1; j < i; j++){
                li[j] = list[i-1][j-1] + list[i-1][j];
            }
        }
        
        return list;
    }
}