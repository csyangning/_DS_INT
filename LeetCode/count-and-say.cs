//  https://leetcode.com/problems/count-and-say/
//  
//  The count-and-say sequence is the sequence of integers beginning as follows:
//  1, 11, 21, 1211, 111221, ...
//  
//  1 is read off as "one 1" or 11.
//  11 is read off as "two 1s" or 21.
//  21 is read off as "one 2, then one 1" or 1211.
//  Given an integer n, generate the nth sequence.
//  
//  Note: The sequence of integers will be represented as a string.

public class Solution {
    public string CountAndSay(int n) {
    	string current = "1";
		
		while(--n != 0)
		{
			string next = string.Empty;
			int startIndex = 0;
			char currentChar = current[startIndex];
			for(int i = 1; i < current.Length; i++)
			{
				if(current[i] != currentChar)
				{
					next += string.Format("{0}{1}", (i - startIndex), currentChar);
					startIndex = i;
					currentChar = current[i]; 
				}
			}
			
			next += string.Format("{0}{1}", (current.Length - startIndex), currentChar);
			current = next;
		}
		
		return current;
	    
    }
}