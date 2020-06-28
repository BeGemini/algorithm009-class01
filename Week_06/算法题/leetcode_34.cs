public class Solution {
    public int LongestValidParentheses(string s) {
    if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        Stack<int> stack = new Stack<int>();
        int maxVal = 0;
        if (s[0] == '(')
        {
            stack.Push(-1);
        }
        else
        {
            stack.Push(0);
        }
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '(')
            {
                stack.Push(i);
            }
            else
            {
                if (stack.Count > 1)
                {
                    stack.Pop();
                    maxVal = Math.Max(maxVal, i - stack.Peek());
                }
                else
                {
                    stack.Clear();
                    stack.Push(i);
                }
            }
        }
        return maxVal;
    }
}