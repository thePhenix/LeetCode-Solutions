// https://leetcode.com/problems/removing-stars-from-a-string

public class Solution {
    public string RemoveStars(string s) {
        var result = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    if (result.Length > 0)
                    {
                        result.Remove(result.Length - 1, 1);
                    }
                }
                else
                {
                    result.Insert(result.Length, s[i]);
                }
            }

            return result.ToString();
    }
}