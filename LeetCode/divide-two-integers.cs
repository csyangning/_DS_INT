// https://leetcode.com/problems/divide-two-integers/
// 
// Divide two integers without using multiplication, division and mod operator.
// 
// If it is overflow, return MAX_INT.


public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            return int.MaxValue;
        }

        long result = 0;
        long absDividend = Math.Abs((long)dividend);
        long absDivisor = Math.Abs((long)divisor);

        int sign = ((dividend > 0) ^ (divisor > 0)) ? -1 : 1;

        while (absDividend >= absDivisor)
        {
            long temp = absDivisor;
            long power = 1;

            while ((temp << 1) < absDividend)
            {
                temp <<= 1;
                power <<= 1;
            }

            result += power;
            absDividend -= temp;
        }

        return Math.Min(Math.Max(sign * (int)result, int.MinValue), int.MaxValue);
    }
}