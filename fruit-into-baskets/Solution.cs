// https://leetcode.com/problems/fruit-into-baskets

public class Solution {
    public int TotalFruit(int[] fruits) {
        int max = 0;
            int treeCount = fruits.Length;

            if (treeCount <= 2)
            {
                return treeCount;
            }

            for (var i = 0; i < treeCount - 1; i++)
            {
                var start = fruits[i];
                var next = fruits[i + 1] != start ? fruits[i + 1] : -1;

                var nextCount = 0;
                for (var j = i; j < treeCount; j++)
                {
                    if (next < 0 && fruits[j] != start)
                    {
                        next = fruits[j];
                    }

                    if (fruits[j] == start || fruits[j] == next)
                    {
                        nextCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (nextCount > max)
                {
                    max = nextCount;
                }
            }
        return max;
    }
}