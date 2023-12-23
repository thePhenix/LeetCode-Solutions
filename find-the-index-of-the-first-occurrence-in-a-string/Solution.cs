// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string

public class Solution {
    public int StrStr(string haystack, string needle) {
        int i = 0;
        int j = 0;
        int position = -1;

        while(i < haystack.Length){
            while(j < needle.Length && i < haystack.Length){
                if(haystack[i] != needle[j])
                {
                    i = i - j + 1;
                    j = 0;
                    break;
                }
                else
                {
                    i++;
                    j++;
                }

                if(j == needle.Length){
                    position = i - needle.Length;
                    return position;
                }
            }
        }

        return position;
    }
}