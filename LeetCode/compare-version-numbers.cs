// https://leetcode.com/problems/compare-version-numbers/

// Compare two version numbers version1 and version2.
// If version1 > version2 return 1, if version1 < version2 return -1, otherwise return 0.
// 
// You may assume that the version strings are non-empty and contain only digits and the . character.
// The . character does not represent a decimal point and is used to separate number sequences.
// For instance, 2.5 is not "two and a half" or "half way to version three", it is the fifth second-level revision of the second first-level revision.
// 
// Here is an example of version numbers ordering:
// 
// 0.1 < 1.1 < 1.2 < 13.37

public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] v1 = version1.Split('.');
        string[] v2 = version2.Split('.');
        
        for(int i = 0; i < v1.Length; i++)
        {
            int dig1 = int.Parse(v1[i]);
            int dig2 = 0;
            if(i < v2.Length)
            {
                dig2 = int.Parse(v2[i]);
            }
            
            if(dig1 > dig2)
            {
                return 1;
            }
            else if(dig1 < dig2)
            {
                return -1;
            }
        }
        
        if(v2.Length > v1.Length)
        {
            for(int j = v1.Length; j < v2.Length; j++)
            {
                if(int.Parse(v2[j]) > 0)
                {
                    return -1;
                }
            }
        }
        
        return 0;
    }
}