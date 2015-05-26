// https://leetcode.com/problems/edit-distance/
// 
// Given two words word1 and word2, find the minimum number of steps required to convert word1 to word2. (each operation is counted as 1 step.)
// 
// You have the following 3 operations permitted on a word:
// 
// a) Insert a character
// b) Delete a character
// c) Replace a character


Use f[i][j] to represent the shortest edit distance between word1[0,i) and word2[0, j). Then compare the last character of word1[0,i) and word2[0,j), which are c and d respectively (c == word1[i-1], d == word2[j-1]):

if c == d, then : f[i][j] = f[i-1][j-1]

Otherwise we can use three operations to convert word1 to word2:

(a) if we replaced c with d: f[i][j] = f[i-1][j-1] + 1;

(b) if we added d after c: f[i][j] = f[i][j-1] + 1;

(c) if we deleted c: f[i][j] = f[i-1][j] + 1;

public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        if (string.IsNullOrEmpty(word2) && string.IsNullOrEmpty(word1))
        {
            return 0;
        }
        else if (string.IsNullOrEmpty(word1) && !string.IsNullOrEmpty(word2))
        {
            return word2.Length;
        }
        else if (!string.IsNullOrEmpty(word1) && string.IsNullOrEmpty(word2))
        {
            return word1.Length;
        }

        int[,] minDis = new int[word1.Length + 1, word2.Length + 1];

        for (int i = 0; i <= word1.Length; i++)
        {
            minDis[i, 0] = i;
        }
        for (int j = 0; j <= word1.Length; j++)
        {
            minDis[0, j] = j;
        }


        for (int i = 1; i <= word1.Length; i++)
        {
            for (int j = 1; j <= word2.Length; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    minDis[i, j] = minDis[i - 1, j - 1];
                }
                else
                {
                    minDis[i, j] = Math.Min(Math.Min(minDis[i - 1, j - 1] + 1, minDis[i, j - 1] + 1), minDis[i - 1, j] + 1);
                }
            }
        }

        return minDis[word1.Length, word2.Length];
    }
}