//  https://leetcode.com/problems/substring-with-concatenation-of-all-words/
//  
//  You are given a string, s, and a list of words, words, that are all of the same length. Find all starting indices of substring(s) in s that is a concatenation of each word in words exactly once and without any intervening characters.
//  
//  For example, given:
//  s: "barfoothefoobarman"
//  words: ["foo", "bar"]
//  
//  You should return the indices: [0,9].
//  (order does not matter).


public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        List<int> result = new List<int>();
        
        if(string.IsNullOrEmpty(s) || words == null || words.Length == 0)
        {
            return result;
        }
        
        int wSize = words[0].Length;
        int wordCount = words.Length;
        int wordLength = wSize * wordCount;
        
        Dictionary<string,int> dic = new Dictionary<string, int>();
        
        foreach(string word in words)
        {
            if(dic.ContainsKey(word))
            {
                dic[word]++;
            }
            else
            {
                dic.Add(word, 1);
            }
        }
        
        for(int i = 0; i <= s.Length - wordLength; i++)
        {
            int count = 0;
            Dictionary<string,int> tDic = new Dictionary<string,int>(dic);
            for(int j = i; j < s.Length; j += wSize)
            {
                string str = s.Substring(j, wSize);
                if(tDic.ContainsKey(str) && tDic[str] != 0)
                {
                    tDic[str]--;
                    count++;
                    
                    if(count == wordCount)
                    {
                        result.Add(i);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
        return result;
    }
}