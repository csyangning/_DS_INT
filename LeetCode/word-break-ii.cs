// https://leetcode.com/problems/word-break-ii/

// Given a string s and a dictionary of words dict, add spaces in s to construct a sentence where each word is a valid dictionary word.
// 
// Return all such possible sentences.
// 
// For example, given
// s = "catsanddog",
// dict = ["cat", "cats", "and", "sand", "dog"].
// 
// A solution is ["cats and dog", "cat sand dog"].

// MEMORY ISSUE!
 public class Solution
  {
      public IList<string> WordBreak(string s, ISet<string> wordDict)
      {
          List<List<string>> map = new List<List<string>>();
          for (int i = 0; i < s.Length; i++)
          {
              map.Add(new List<string>());
          }

          for (int i = 0; i < s.Length; i++)
          {
              if (wordDict.Contains(s.Substring(0, i + 1)))
              {
                  map[i].Add(s.Substring(0, i + 1));
              }
              for (int j = 0; j < i; j++)
              {
                  string word = s.Substring(j + 1, i - j);
                  if (map[j].Count != 0 && wordDict.Contains(word))
                  {
                      foreach (string str in map[j])
                      {
                          map[i].Add(str + " " + word);
                      }
                  }
              }
          }

          return map[s.Length - 1];
      }
  }