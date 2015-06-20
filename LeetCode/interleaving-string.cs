//  https://leetcode.com/problems/interleaving-string/
//  
//  Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.
//  
//  For example,
//  Given:
//  s1 = "aabcc",
//  s2 = "dbbca",
//  
//  When s3 = "aadbbcbcac", return true.
//  When s3 = "aadbbbaccc", return false.

public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
		
		if(s3.Length != (s1.Length + s2.Length))
		{
		    return false;
		}
		
        bool[,] canInterleave = new bool[s1.Length + 1, s2.Length + 1];
		
		for(int i = 0; i <= s1.Length; i++)
		{
			for(int j = 0; j <= s2.Length; j++)
			{
				if(i==0 && j == 0)
				{
					canInterleave[i,j] = true;
				}
				else if(i == 0)
				{
					canInterleave[i,j] = (s3[j - 1] == s2[j - 1] && canInterleave[i,j - 1]);
				}
				else if(j == 0)
				{
					canInterleave[i,j] = (s3[i - 1] == s1[i - 1] && canInterleave[i - 1,j]);
				}
				else
				{
					canInterleave[i,j] = (s3[i + j - 1] == s1[i - 1] && canInterleave[i - 1,j]) || (s3[i + j - 1] == s2[j - 1] && canInterleave[i,j - 1]);
				}
			}
		}
		
		return canInterleave[s1.Length, s2.Length];
    }
}