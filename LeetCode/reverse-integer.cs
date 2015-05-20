// https://leetcode.com/problems/reverse-integer/
// 
// Reverse digits of an integer.
// 
// Example1: x = 123, return 321
// Example2: x = -123, return -321


public class Solution
{
    public int Reverse(int x)
    {
        long result = 0;
        while (x != 0)
        {
            int tail = x % 10;
            if ((result * 10 + tail) > int.MaxValue || (result * 10 + tail) < int.MinValue)
            {
                return 0;
            }
            else
            {
                result = result * 10 + tail;
            }
            x = x / 10;
        }
        return (int)result;
    }
}