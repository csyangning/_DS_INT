// https://leetcode.com/problems/anagrams/
// 
// Given an array of strings, return all groups of strings that are anagrams.
// 
// Note: All inputs will be in lower-case.

// without sort
public class Solution {
    private static int[] PRIMES = new int[]{2, 3, 5, 7, 11 ,13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 107};
    
    public IList<string> Anagrams(string[] strs) {
        List<string> result = new List<string>();
        Dictionary<int, List<string>> stringHash = new Dictionary<int, List<string>>();
        
        foreach(string str in strs)
        {
            int hashValue = this.GetHashCode(str);
            if(!stringHash.ContainsKey(hashValue))
            {
                stringHash.Add(hashValue, new List<string>());
            }
            
            stringHash[hashValue].Add(str);            
        }
        
        foreach(List<string> strList in stringHash.Values)
        {
            if(strList.Count > 1)
            {
                result.AddRange(strList);
            }
        }
        
        return result;
    }
    
    private int GetHashCode(string s)
    {
        int hashValue = 0;
        foreach(char c in s)
        {
            hashValue += PRIMES[c - 'a'];
        }
        
        return hashValue;
    }
}

// with sort
public class Solution
    {
        public IList<string> Anagrams(string[] strs)
        {
            List<string> result = new List<string>();
            Dictionary<string, List<string>> stringHash = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                var charArr = str.ToCharArray();
                Array.Sort(charArr);
                string hashValue = new string(charArr);
                if (!stringHash.ContainsKey(hashValue))
                {
                    stringHash.Add(hashValue, new List<string>());
                }

                stringHash[hashValue].Add(str);
            }

            foreach(List<string> strList in stringHash.Values)
            {
                if(strList.Count > 1)
                {
                    result.AddRange(strList);
                }
            }

            return result;
        }

    }