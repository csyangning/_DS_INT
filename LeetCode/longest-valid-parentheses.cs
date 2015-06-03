// https://leetcode.com/problems/longest-valid-parentheses/
// 
// Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
// 
// For "(()", the longest valid parentheses substring is "()", which has length = 2.
// 
// Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.

public class Solution {
    public int LongestValidParentheses(string s) {
        if(string.IsNullOrEmpty(s))
		{
			return 0;
		}
		
		Stack<int> stack  = new Stack<int>();
		
		for(int i = 0; i < s.Length; i++)
		{
			if(s[i] == '(')
			{
				stack.Push(i);
			}
			else
			{
				if(stack.Count > 0 && s[stack.Peek()] == '(')
				{
					stack.Pop();
				}
				else
				{
					stack.Push(i);
				}
			}
		}
		
		if(stack.Count == 0)
		{
			return s.Length;
		}
		else
		{
			int maxLength = 0;
			
			int end = s.Length;
			while(stack.Count != 0)
			{
				int start = stack.Pop();
				maxLength = Math.Max(maxLength, end - start - 1);
				end = start;
			}
			
			return Math.Max(maxLength, end);
		}
	}
}