// https://leetcode.com/problems/adding-spaces-to-a-string

public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        var result = new StringBuilder();
            var j = 0;
            var spaceLength = spaces.Length;
            for (var i = 0; i < s.Length; i++)
            {
                if (i == spaces[j])
                {
                    result.Append(" ");
                    if (j < spaceLength - 1)
                    {
                        j++;
                    }
                }

                result.Append(s[i]);
            }
        
        return result.ToString();
    }
}