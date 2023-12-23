// https://leetcode.com/problems/pascals-triangle-ii

public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<IList<int>> list = new List<IList<int>>() { new List<int> {1}};
        
        for(var i = 2; i<= rowIndex + 1; i++){
            var li = new List<int>{1};
            for(var j = 1; j< i-1; j++){
                li.Add(list[i-2][j-1] + list[i-2][j]);
            }
            li.Add(1);
            list.Add(li);
        }
        
        return list[rowIndex];
    }
}