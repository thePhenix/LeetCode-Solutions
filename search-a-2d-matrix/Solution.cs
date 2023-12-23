// https://leetcode.com/problems/search-a-2d-matrix

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int rLow = 0;
        int rHigh = m - 1;
        int cLow = 0;
        int cHigh = n - 1;
        int searchRow = -1;
        while(rLow <= rHigh){
            int rMid = (rLow + rHigh) / 2;
            if(target >= matrix[rMid][0] && target <= matrix[rMid][n-1]){
                searchRow = rMid;
                break;
            }else if(target < matrix[rMid][0]){
                rHigh = rMid - 1;
            }else{
                rLow = rMid + 1;
            }
        }

        if(searchRow >= 0){
            while(cLow <= cHigh){
                int mid = (cLow + cHigh) /2;
                if(matrix[searchRow][mid] == target){
                    return true;
                }else if(matrix[searchRow][mid] > target){
                    cHigh = mid - 1;
                }else{
                    cLow = mid + 1;
                }
            }
        }
        
        return false;

    }
}