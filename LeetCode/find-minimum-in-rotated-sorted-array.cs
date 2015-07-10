//  https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
//  
//  Suppose a sorted array is rotated at some pivot unknown to you beforehand.
//  
//  (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
//  
//  Find the minimum element.
//  
//  You may assume no duplicate exists in the array.

public class Solution {
    public int FindMin(int[] nums) {
        
        if(nums == null)
        {
            return -1;
        }
        
        return FindMin(nums, 0, nums.Length - 1);
    }
    
    private int FindMin(int[] nums, int start, int stop)
    {
        if(nums[start] < nums[stop] || start == stop)
        {
            return nums[start];
        }
        else
        {
            int middle = (start + stop) / 2;
            if(nums[middle] >= nums[start])
            {
                return FindMin(nums, middle + 1, stop);
            }
            else
            {
                return FindMin(nums, start, middle);
            }
        }
    }
}