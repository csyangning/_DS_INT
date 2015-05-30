// https://leetcode.com/problems/trapping-rain-water/

// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
// 
// For example, 
// Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.

public class Solution {
    public int Trap(int[] height) {
        int left = 0;
		int right = height.Length - 1;
		int maxLeft = 0;
		int maxRight = 0;
		int result;
		
		while(left <= right)
		{
			if(height[left] <= height[right])
			{
				if(height[left] >= maxLeft) maxLeft = height[left];
				else result += maxLeft - height[left]
				left++;
			}
			else
			{
				if(height[right] >= maxRight) maxRight = height[right];
				else result += maxRight - height[right];
				right--;
			}
		} 
		
		return result;
    }
}