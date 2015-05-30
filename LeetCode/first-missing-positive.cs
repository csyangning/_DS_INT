// https://leetcode.com/problems/first-missing-positive/
// 
// Given an unsorted integer array, find the first missing positive integer.
// 
// For example,
// Given [1,2,0] return 3,
// and [3,4,-1,1] return 2.
// 
// Your algorithm should run in O(n) time and uses constant space.

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for(int i = 0; i < nums.Length;)
        {
            if(nums[i] > 0 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1])
            {
                int temp = nums[i];
                nums[i] = nums[nums[i] - 1];
                nums[temp - 1] = temp;
            }
            else
            {
                 i++;
            }
        }
        
        int j = 0; 
        while(j < nums.Length)
        {
            if(nums[j] != j + 1)
            {
                return j + 1;
            }
            j++;
        }
        
        return nums.Length + 1;
    }
    
    
}