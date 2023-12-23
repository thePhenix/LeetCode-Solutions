// https://leetcode.com/problems/flood-fill

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int rLen = image.Length;
        int cLen = image[0].Length;
        bool[][] visited = new bool[rLen][];
        for(var i = 0; i < rLen; i++){
            visited[i] = new bool[image[0].Length];
        }

        int initColor = image[sr][sc];
        var queue = new Queue<(int,int)>();

        queue.Enqueue((sr,sc));
        visited[sr][sc] = true;
        image[sr][sc] = color;

        while(queue.Count > 0){
            var curr = queue.Dequeue();
            var row = curr.Item1;
            var col = curr.Item2;
            var neighbours = new List<(int,int)>()
            {
                (row - 1, col),
                (row, col - 1),
                (row + 1, col),
                (row, col + 1)
            };

            for(var i = 0; i < 4; i++)
            {
                var r = neighbours[i].Item1;
                var c = neighbours[i].Item2;
                if(r >= 0 && r < rLen && c >= 0 && c < cLen && !visited[r][c]){
                    if(image[r][c] == initColor){
                        visited[r][c] = true;
                        image[r][c] = color;
                        queue.Enqueue((r,c));
                    }
                }
            }
        }

        return image;

    }
}