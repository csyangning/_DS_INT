//  https://leetcode.com/problems/reverse-words-in-a-string/
//  
//  Given an input string, reverse the string word by word.
//  
//  For example,
//  Given s = "the sky is blue",
//  return "blue is sky the".

public class Solution {
    public string ReverseWords(string s) {
        
        if(string.IsNullOrEmpty(s))
        {
            return s;
        }
        
        char[] ca = s.ToArray();
        int start = 0;
        
        for(int i = 0; i < ca.Length; i++)
        {
            if(ca[i] == ' ')
            {
                if(start != 0)
                {
                    revert(ca, start, i - 1);
                }
                
                start = 0;                
            }
            else if(start == 0)
            {
                start = i;
            }   
        }
		
        if(start != 0)
        {
            revert(ca, start, ca.Length - 1);
        }
        
		revert(ca, 0, ca.Length - 1);
        return ca.ToString();
    }
    
    private void revert(char[] s, int start, int end)
	{
		while(start < end)
		{
			char tmp = s[start];
			s[start] = s[end];
			s[end] = tmp;
			start++; end--;
		}
	}
}