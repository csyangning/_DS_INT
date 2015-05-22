// https://leetcode.com/problems/wildcard-matching/

// Implement wildcard pattern matching with support for '?' and '*'.
// 
// '?' Matches any single character.
// '*' Matches any sequence of characters (including the empty sequence).
// 
// The matching should cover the entire input string (not partial).
// 
// The function prototype should be:
// bool isMatch(const char *s, const char *p)
// 
// Some examples:
// isMatch("aa","a") → false
// isMatch("aa","aa") → true
// isMatch("aaa","aa") → false
// isMatch("aa", "*") → true
// isMatch("aa", "a*") → true
// isMatch("ab", "?*") → true
// isMatch("aab", "c*a*b") → false

public class Solution
{
    public bool IsMatch(string s, string p)
    {
        if (s == p)
        {
            return true;
        }

        int i = 0, j = 0, startIndex = -1, savedPoint = 0;

        while (i < s.Length )
        {
            if (j < p.Length && (s[i] == p[j] || p[j] == '?'))
            {
                j++;
                i++;
            }
            else
            {
                if (j < p.Length && p[j] == '*')
                {
                    startIndex = j;
                    savedPoint = i;
                    j++;
                }
                else if (startIndex != -1)
                {
                    j = startIndex + 1;
                    i = ++savedPoint;

                }
                else
                {
                    return false;
                }
            }


        }

        while (j < p.Length && p[j] == '*')
        {
            j++;
        }
        if (j == p.Length && i == s.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}