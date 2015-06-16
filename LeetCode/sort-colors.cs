//  https://leetcode.com/problems/sort-colors/
//  
//  Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, with the colors in the order red, white and blue.
//  
//  Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
//  
//  Note:
//  You are not suppose to use the library's sort function for this problem.


public class Solution
    {
        public void SortColors(int[] nums)
        {
            int zero = 0;
            int two = nums.Length - 1;
            
            for(int i = 0; i <= two; i++)
            {
                while(nums[i] == 2 && i < two) { Swap(nums, i, two--);}
                while(nums[i] == 0 && i > zero) { Swap(nums, i, zero++); }
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
    }
	
	

public class Solution
    {
        public void SortColors(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }

            int whitePoint = -1;
            int bluePoint = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (whitePoint != -1)
                    {
                        Swap(nums, i, whitePoint++);
                    }

                    if (bluePoint != -1)
                    {
                        Swap(nums, i, bluePoint++);
                    }

                }
                else if (nums[i] == 1)
                {
                    if (bluePoint != -1)
                    {
                        Swap(nums, i, bluePoint++);

                        if (whitePoint == -1)
                        {
                            whitePoint = bluePoint - 1;
                        }
                    }

                    if (whitePoint == -1)
                    {
                        whitePoint = i;
                    }
                }
                else
                {
                    if (bluePoint == -1)
                    {
                        bluePoint = i;
                    }
                }
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
    }