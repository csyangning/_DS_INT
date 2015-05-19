// https://leetcode.com/problems/longest-substring-without-repeating-characters/
// 
// Given a string, find the length of the longest substring without repeating characters. 
// For example, the longest substring without repeating letters for "abcabcbb" is "abc", which the length is 3. 
// For "bbbbb" the longest substring is "b", with the length of 1.

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null)
        {
            return 0;
        }
        
        int maxLength = 0;
        LinkedList<char> queue = new LinkedList<char>();
        
        foreach(char c in s)
        {
            if(queue.Contains(c))
            {
                while(queue.First.Value != c)
                {
                    queue.RemoveFirst();
                }
                queue.RemoveFirst();
            }
            
            queue.AddLast(c);
            if(queue.Count > maxLength)
            {
                maxLength = queue.Count;
            }
        }
    
        return maxLength;
    }
}