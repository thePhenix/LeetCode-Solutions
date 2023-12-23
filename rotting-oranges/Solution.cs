// https://leetcode.com/problems/rotting-oranges

public class Solution {
    public int OrangesRotting(int[][] grid) {
        var visited = new bool[grid.Length][];
        for(var i = 0; i < grid.Length; i++){
            visited[i] = new bool[grid[0].Length];
        }

        int timeTaken = 0;

        var queue = new Queue<((int,int),int)>();
        for(var i = 0; i < grid.Length; i++){
            for(var j = 0; j< grid[0].Length; j++){
                if(grid[i][j] == 2){
                    queue.Enqueue(((i,j), 0));
                    visited[i][j] = true;
                }
            }
        }

        var delta = new List<(int, int)>() {
            (0, -1),
            (-1, 0),
            (0, +1),
            (+1, 0)
        };

        while(queue.Count() > 0){
            var item = queue.Dequeue();
            var row = item.Item1.Item1;
            var col = item.Item1.Item2;
            var level = item.Item2;
            
            if(level > timeTaken){
                timeTaken = level;
            }

            for(var i = 0; i<4; i++){
                var d = delta[i];
                var dRow = row + d.Item1;
                var dCol = col + d.Item2;
                if(dRow >= 0 && dRow<grid.Length && dCol >=0 && dCol<grid[0].Length && !visited[dRow][dCol] && grid[dRow][dCol] == 1){
                    queue.Enqueue(((dRow,dCol), level +  1));
                    visited[dRow][dCol] = true;
                    grid[dRow][dCol] = 2;
                }
            }
        }

        for(var i = 0; i < grid.Length; i++){
            for (var j = 0; j < grid[0].Length; j++){
                if(grid[i][j] == 1){
                    return -1;
                }
            }
        }

        return timeTaken;
    }
}