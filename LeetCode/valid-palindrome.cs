// https://leetcode.com/problems/valid-palindrome/
// 
// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
// 
// For example,
// "A man, a plan, a canal: Panama" is a palindrome.
// "race a car" is not a palindrome.
// 
// Note:
// Have you consider that the string might be empty? This is a good question to ask during an interview.
// 
// For the purpose of this problem, we define empty string as valid palindrome

public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }

        int left = 0;
        int right = s.Length - 1;
        string ls = s.ToLowerInvariant();
        while (left < right)
        {
            if (!isAlpha(ls[left]))
            {
                left++;
            }
            else if (!isAlpha(ls[right]))
            {
                right--;
            }
            else
            {
                if (ls[left] != ls[right])
                {
                    return false;
                }
                else
                {
                    left++; right--;
                }
            }
        }

        return true;
    }

    private bool isAlpha(char a)
    {
        return (a >= 'a' && a <= 'z') || (a >= '0' && a <= '9');
    }
}