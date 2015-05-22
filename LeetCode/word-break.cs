// https://leetcode.com/problems/word-break/
// 
// Given a string s and a dictionary of words dict, determine if s can be segmented into a space-separated sequence of one or more dictionary words.
// 
// For example, given
// s = "leetcode",
// dict = ["leet", "code"].
// 
// Return true because "leetcode" can be segmented as "leet code".


// DP, F[i] = true if we can find j, where F[i-j] == true and s[j+1,i] is in dict
public class Solution
{
  public bool WordBreak(string s, ISet<string> wordDict)
  {
      bool[] canBreak = new bool[s.Length + 1];
      canBreak[0] = true; 

      for (int i = 1; i <= s.Length; i++)
      {
          for (int j = 0; j < i; j++)
          {
              if (canBreak[j] == true && wordDict.Contains(s.Substring(j, i - j)))
              {
                  canBreak[i] = true;
                  break;
              }
          }
      }

      return canBreak[s.Length];
  }
}