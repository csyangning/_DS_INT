//  https://leetcode.com/problems/generate-parentheses/
//  
//  Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
//  
//  For example, given n = 3, a solution set is:
//  
//  "((()))", "(()())", "(())()", "()(())", "()()()"

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
		
		GenerateParenthesis(1, n - 1, "(", result);
		
		return result;
    }
	
	public void GenerateParenthesis(int currentLeft, int parenthesesLeft, string currentString, List<string> result)
	{
		if(parenthesesLeft == 0 && currentLeft == 0)
		{
			result.Add(currentString);
			return;
		}
		
		if(currentLeft > 0)
		{
			GenerateParenthesis(currentLeft - 1, parenthesesLeft, currentString + ")", result);
			
			if(parenthesesLeft > 0)
			{
				GenerateParenthesis(currentLeft + 1, parenthesesLeft - 1, currentString + "(", result);
			}
		}
		else
		{
			GenerateParenthesis(1, parenthesesLeft - 1, currentString + "(", result);
		}
	}
}