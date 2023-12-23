// https://leetcode.com/problems/number-of-islands

public class Solution {
    public void Bfs(char[][] grid, bool[][] visited, int i, int j, int m, int n){
        var queue = new Queue<(int, int)>();
        visited[i][j] = true;
        queue.Enqueue((i,j));
        while(queue.Count > 0)
        {
            var front = queue.Dequeue();
            var first = front.Item1;
            var second = front.Item2;

            var neighbour = new List<(int, int)>()
            {
                (first - 1, second),
                (first, second - 1),
                (first, second + 1),
                (first + 1, second),
            };

            for(var item = 0; item < 4; item++)
            {
                var nRow = neighbour[item].Item1;
                var nCol = neighbour[item].Item2;
                if(nRow >= 0 && nRow < m && nCol >=0 && nCol < n)
                {
                    if(!visited[nRow][nCol] && grid[nRow][nCol] == '1')
                    {
                        visited[nRow][nCol] = true;
                        queue.Enqueue((nRow, nCol));
                    }
                }
            }
        }
    }
    
    public int NumIslands(char[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;
        var visited = new bool[m][];
        for(var i = 0; i < m; i++){
            visited[i] = new bool[n];
            for (var j = 0; j< n; j++){
               visited[i][j] = false;
            }
        }

        int count = 0;

        for(var i = 0;i<m;i++){
            for(var j =0; j<n; j++){
                if(!visited[i][j] && grid[i][j] == '1'){
                    count++;
                    Bfs(grid,visited, i, j, m, n);
                }
            }
        }

        return count;
    }
}