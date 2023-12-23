// https://leetcode.com/problems/reverse-integer

public class Solution {
    public int Reverse(int x) {
        long result = 0;

            while (x != 0)
            {
                result = result * 10 + x % 10;
                if (result > Int32.MaxValue || result < Int32.MinValue)
                {
                    return 0;
                }
                x = x / 10;
            }

            return (int)result;
    }
}