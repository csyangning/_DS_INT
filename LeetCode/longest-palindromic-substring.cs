// https://leetcode.com/problems/longest-palindromic-substring/

// Given a string S, find the longest palindromic substring in S. 
// You may assume that the maximum length of S is 1000, and there exists one unique longest palindromic substring.

public class Solution {
    public string LongestPalindrome(string s) 
    {
        int longestLen = 0;
        int longestIndex = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(isPalindrome(s, i - longestLen, i))
            {
                longestLen += 1;
                longestIndex = i;
            }
            else if(i - longestLen - 1 >= 0 && (isPalindrome(s, i - longestLen - 1, i)))
            {
                longestLen += 2;
                longestIndex = i;
            }
        }
        
        return s.Substring(longestIndex + 1 - longestLen, longestLen);    
    }
    
    private bool isPalindrome(string s, int startIndex, int endIndex)
    {
        for(int i = startIndex, j = endIndex; i < j ; i++, j--)
        {
            if(s[i] != s[j])
            {
                return false;
            }
        }
        
        return true;
    }
}
// 
// # The key intuition of this algorithm is that palindromes are made up of
// # smaller palindromes.
// 
// # So, a palindrome of length 100 (for example), will have a palindrome of
// # length 98 inside it, and one of length 96, ... 50, ... 4, and 2.
// 
// # Because of this, we can move across our string, checking if the current
// # place is a palindrome of a particular length (the longest length palindrome
// # found so far + 1), and if it is, update the longest length, and move forward.
// 
// # In this way, we find our longest palindromes "from the inside out", starting
// # with length x, then x+2, x+4, ...
// 
// # Example:
// # "xxABCDCBAio"
// #  0123456789  < indexes
// # As we scan our string, we initially find a palindrome of length 2 (xx)
// # We always look backwards!
// # When we get to index 2,3,4, we see no length 3+ palindrome ending there.
// # But when we get to index 6, looking back 3 characters, we see "CDC"! So our
// # longest palindrome is now length 3.
// # At index 7, we look back and see no length 4 palindromes, but find one of
// # length 5 ("BCDCB").
// # And finally, by i = 8, we find the full "ABCDCBA"
// 
// # Hope that helps!