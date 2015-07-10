// https://leetcode.com/problems/string-to-integer-atoi/

// Implement atoi to convert a string to an integer.

public class Solution {
    public int MyAtoi(string str) {
        
        double result = 0;
        int sign = 1;
        bool signSet = false;
        
        foreach(char c in str.Trim())
        {
            if(c >= '0' && c <= '9')
            {
                result = result * 10 + c - '0';
            }
            else if(c == '-' && !signSet)
            {
                sign = -1;
                signSet = true;
            }
            else if (c == '+' && !signSet)
            {
                sign = 1;
                signSet = true;
            }
            else
            {
                break;
            }
        }
        
        result = sign * result;
        
        result = Math.Min(result, int.MaxValue);
        result = Math.Max(result, int.MinValue);
        
        return (int)result;
    }
}