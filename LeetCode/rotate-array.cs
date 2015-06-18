//  https://leetcode.com/problems/rotate-array/
//  
//  Rotate an array of n elements to the right by k steps.
//  
//  For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is rotated to [5,6,7,1,2,3,4].
//  
//  Note:
//  Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.

public class Solution {
    public void Rotate(int[] nums, int k) {
        if(nums == null || k == 0 || k % nums.Length == 0)
		{
			return;
		}
		
		k = k % nums.Length;
		
		revert(nums, 0, nums.Length - k - 1);
		revert(nums, nums.Length - k, nums.Length - 1);
		revert(nums, 0, nums.Length - 1);
    }
	
	private void revert(int[] nums, int start, int end)
	{
		while(start < end)
		{
			int tmp = nums[start];
			nums[start] = nums[end];
			nums[end] = tmp;
			start++; end--;
		}
	}
}