// https://leetcode.com/problems/house-robber/
// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is 
// that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
// 
// Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
// 
// Credits:
// Special thanks to @ifanchu for adding this problem and creating all test cases. Also thanks to @ts for adding additional test cases.

public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        int[] maxValueRob = new int[nums.Length];
        int[] maxValueNotRob = new int[nums.Length];
        maxValueRob[0] = nums[0];
        maxValueNotRob[0] = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            maxValueRob[i] = maxValueNotRob[i - 1] + nums[i];
            maxValueNotRob[i] = Math.Max(maxValueRob[i - 1], maxValueNotRob[i - 1]);
        }

        return Math.Max(maxValueRob[nums.Length - 1], maxValueNotRob[nums.Length - 1]);
    }
}