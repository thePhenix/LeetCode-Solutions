// https://leetcode.com/problems/roman-to-integer

public class Solution {
    public int RomanToInt(string input) {
        var dict = new Dictionary<char, int> {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
        
            var integer = 0;
            
            if (input != null)
            {
                var length = input.Length;
                var lastNumber = dict[input[length - 1]];
                integer = lastNumber;

                for (var i = input.Length - 2; i >= 0; i--)
                {
                    var current = dict[input[i]];
                    if (current < lastNumber)
                    {
                        integer -= current;
                    }
                    else
                    {
                        integer += current;
                    }

                    lastNumber = current;
                }
            }
        
        return integer;
    }
}