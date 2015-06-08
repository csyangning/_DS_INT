//  https://leetcode.com/problems/maximum-product-subarray/
//  
//  Find the contiguous subarray within an array (containing at least one number) which has the largest product.
//  
//  For example, given the array [2,3,-2,4],
//  the contiguous subarray [2,3] has the largest product = 6.

public class Solution
  {
      public int MaxProduct(int[] nums) {
        if(nums == null || nums.Length == 0)
        {
            return 0;
        }
        
        int maxProduct = nums[0];
        int[] maxPos = new int[nums.Length];
        int[] maxNeg = new int[nums.Length];
        if(nums[0] > 0)
        {
            maxPos[0] = nums[0];
        }
        else
        {
            maxNeg[0] = nums[0];
        }
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                if(maxPos[i-1] != 0)
                {
                    maxPos[i] = maxPos[i-1] * nums[i];
                }
                else
                {
                    maxPos[i] = nums[i];
                }
                
                if(maxNeg[i-1] != 0)
                {
                    maxNeg[i] = maxNeg[i-1]*nums[i];
                }
            }
            else if(nums[i] < 0)
            {
                if(maxNeg[i-1] != 0)
                {
                    maxPos[i] = maxNeg[i-1] * nums[i];
                }
                
                if(maxPos[i-1] != 0)
                {
                    maxNeg[i] = maxPos[i-1] * nums[i];
                }
                else
                {
                    maxNeg[i] = nums[i];
                }
            }
                
            if(maxPos[i] > maxProduct)
            {
                maxProduct = maxPos[i];
            }
        }
        
        return maxProduct;
    }
  }