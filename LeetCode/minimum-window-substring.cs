// https://leetcode.com/problems/minimum-window-substring/

// Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).
// 
// For example,
// S = "ADOBECODEBANC"
// T = "ABC"
// Minimum window is "BANC".

public class Solution
{
        public string MinWindow(string s, string t) {
        if(s == null)
        {
            return string.Empty;
        }
        
        if(string.IsNullOrEmpty(t))
        {
            return s;
        }
        
        Dictionary<char,int> require = new Dictionary<char,int>();
        
        for(int i = 0; i < t.Length; i++)
        {
            if (require.ContainsKey(t[i]))
            {
                require[t[i]]++;
            }
            else
            {
                require.Add(t[i], 1);
            }
        }
        
        int minLength = int.MaxValue;
        int minIndex = 0;
        int count = 0;
        int currentIndex = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(require.ContainsKey(s[i]))
            {
                require[s[i]]--;
                if(require[s[i]] >= 0)
                {
                    count++;
                }
            }
            
            while(count == t.Length)
            {
                if(i-currentIndex + 1 < minLength)
                {
                    minIndex = currentIndex;
                    minLength = i - currentIndex + 1;
                }
                
                if(require.ContainsKey(s[currentIndex]))
                {
                    require[s[currentIndex]]++;
                    if(require[s[currentIndex]] > 0)
                    {
                        count--;
                    }
                }

                currentIndex++;
            }
        }
        
        if(minLength == int.MaxValue) return string.Empty;
        else
        {
            return s.Substring(minIndex, minLength);
        }
        
    }
}