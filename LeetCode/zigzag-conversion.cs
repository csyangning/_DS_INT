// https://leetcode.com/problems/zigzag-conversion/
// 
// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
// 
// P   A   H   N
// A P L S I I G
// Y   I   R
// And then read line by line: "PAHNAPLSIIGYIR"
// Write the code that will take a string and make this conversion given a number of rows:
// 
// string convert(string text, int nRows);
// convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".

public class Solution
{
    public string Convert(string s, int numRows)
    {

        if (s == null)
        {
            return null;
        }
        
        if (numRows == 1)
        {
            return s;
        }
            
        string result = string.Empty;
        int commonDist = (numRows - 1) * 2;

        for (int i = 0; i < numRows; i++)
        {
            int j = i;
            int rowDist = (numRows - i - 1) * 2;
            while (j < s.Length)
            {
                result += s[j];

                if ((i != 0 && i != (numRows - 1)) && (j + rowDist) < s.Length)
                {
                    result += s[j + rowDist];
                }

                j += commonDist;
            }
        }

        return result;
    }
}