// https://leetcode.com/problems/house-robber-ii/

// Note: This is an extension of House Robber.
// 
// After robbing those houses on that street, the thief has found himself a new place for his thievery so that he will not get too much attention. 
// This time, all houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, the security system 
// for these houses remain the same as for those in the previous street.
// 
// Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.

public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

       if(nums.Length == 1)
        {
            return nums[0];
        }
        
        return Math.Max(Rob(nums, 1, nums.Length - 1)), Rob(nums, 0, nums.Length -2));
    }
	
	 public int Rob(int[] nums, int start, int end)
	 {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        int preRob = 0;
        int preNotRob = 0;

        for (int i = start; i <= end; i++)
        {
            int temp = preRob;
            preRob = preNotRob + nums[i];
            preNotRob = Math.Max(temp, preNotRob);
        }

        return Math.Max(preRob, preNotRob);
    }
}