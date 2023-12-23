// https://leetcode.com/problems/valid-parentheses

public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
            foreach (var p in s)
            {
                if (p == '(' || p == '{' || p == '[')
                {
                    stack.Push(p);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        var top = stack.Pop();
                        if ((top == '(' && p != ')') || (top == '{' && p != '}') || (top == '[' && p != ']'))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }

            return false;
    }
}