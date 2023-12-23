// https://leetcode.com/problems/longest-common-prefix

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var result = "";

            if (strs.Length <= 0)
            {
                return result;
            }

            var reference = strs[0];
            for (var i = 0; i < reference.Length; i++)
            {
                var selectedChar = reference[i];
                foreach (var str in strs)
                {
                    if (i >= str.Length || str[i] != selectedChar)
                    {
                        return result;
                    }
                }

                result += selectedChar;
            }

            return result;
    }
}