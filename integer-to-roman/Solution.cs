// https://leetcode.com/problems/integer-to-roman

public class Solution {
    public string IntToRoman(int number) {
        var map = new Dictionary<int, string>
            {
                {1, "I"},
                {4, "IV"},
                {5, "V"},
                {9,"IX"},
                {10,"X"},
                {40,"XL"},
                {50,"L"},
                {90,"XC"},
                {100,"C"},
                {400,"CD"},
                {500,"D"},
                {900,"CM"},
                {1000,"M"},
            };

            
            var output = string.Empty;

            for (int i = map.Count - 1; i >= 0; i--)
            {
                var item = map.ElementAt(i);
                if (item.Key <= number)
                {
                    var j = i;
                    while (number != 0)
                    {
                        var referenceNumber = item.Key;
                        while (number >= referenceNumber)
                        {
                            number -= referenceNumber;
                            output += item.Value;
                        }

                        if (j == 0)
                        {
                            break;
                        }

                        item = map.ElementAt(--j);
                    }

                    break;
                }
            }
        return output;
    }
}