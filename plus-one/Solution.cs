// https://leetcode.com/problems/plus-one

public class Solution {
    public int[] PlusOne(int[] digits) {
        var result = new List<int>();
            var reminder = 0;

            for (var i = digits.Length - 1; i >= 0; i--)
            {
                var newNumber = digits[i] + reminder;
                if (i == digits.Length - 1)
                {
                    newNumber += 1;
                }

                result.Add(newNumber % 10);
                reminder = newNumber / 10;
            }

            while (reminder > 0)
            {
                result.Add(reminder % 10);
                reminder /= 10;
            }

            var output = new int[result.Count];
            var j = 0;
            for (var i = result.Count - 1; i >= 0; i--)
            {
                output[j++] = result[i];
            }

            return output;
    }
}