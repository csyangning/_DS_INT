//  https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/
//  
//  Follow up for "Find Minimum in Rotated Sorted Array":
//  What if duplicates are allowed?
//  
//  Would this affect the run-time complexity? How and why?
//  Suppose a sorted array is rotated at some pivot unknown to you beforehand.
//  
//  (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
//  
//  Find the minimum element.
//  
//  The array may contain duplicates.

public class Solution {
    public int FindMin(int[] nums) {
        int lo = 0;
        int hi = nums.Length - 1;
        
        while(lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            
            if(nums[mid] > nums[hi])
            {
                lo = mid + 1;
            }
            else if(nums[mid] < nums[hi])
            {
                hi = mid;
            }
            else
            {
                hi--;
            }
            
        }
      
        return nums[lo];
    }
}