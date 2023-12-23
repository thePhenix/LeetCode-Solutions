// https://leetcode.com/problems/number-of-provinces

public class Solution {
    public void Bfs(int[][] isConnected, bool[] visited, int item, int n){
        var queue = new Queue<int>();
        queue.Enqueue(item);
        while(queue.Count() > 0){
            item = queue.Peek();
            queue.Dequeue();
            visited[item] = true;
            for(var i=0; i<n;i++){
                if(!visited[i] && isConnected[item][i]==1){
                    queue.Enqueue(i);
                }
            }
        }
    }

    public int FindCircleNum(int[][] isConnected) {
        if(isConnected.Length > 0){
            int len = isConnected.GetLength(0);
            bool[] visited = new bool[len];
            for(var x = 0; x < len; x++){
                visited[x] = false;
            }

            int provinceCount = 0;

            for(var x = 0; x < len; x++){
                if(!visited[x]){
                    provinceCount++;
                    Bfs(isConnected, visited,x, len);
                }
            }

            return provinceCount;
        }

        return 0;
    }
}