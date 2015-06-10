//  https://leetcode.com/problems/palindrome-partitioning/
//  
//  Given a string s, partition s such that every substring of the partition is a palindrome.
//  
//  Return all possible palindrome partitioning of s.
//  
//  For example, given s = "aab",
//  Return
//  
//    [
//      ["aa","b"],
//      ["a","a","b"]
//    ]

public class Solution
{
    public List<List<string>> Partition(string s)
    {
        List<List<string>> result = new List<List<string>>();
        if (!string.IsNullOrEmpty(s))
        {
            List<string> currentPath = new List<string>();
            FindPalindrome(0, s, currentPath, result);
        }

        return result;
    }

    private void FindPalindrome(int index, string s, List<string> currentPath, List<List<string>> result)
{
    if(index == s.Length)
    {
        result.Add(new List<string>(currentPath));
    }
    
    for(int i = index; i < s.Length; i++)
    {
        if(this.IsPalindrome(s, index, i))
        {
            currentPath.Add(s.Substring(index, i - index + 1));
            FindPalindrome(i + 1,  s,  currentPath, result);
            currentPath.RemoveAt(currentPath.Count - 1);
        }
    }
}

    private bool IsPalindrome(string s, int index, int end)
    {
        while (index <= end)
        {
            if (s[index] != s[end])
            {
                return false;
            }

            index++;
            end--;
        }

        return true;
    }
}