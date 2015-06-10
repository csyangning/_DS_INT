//  https://leetcode.com/problems/next-permutation/
//  
//  Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
//  
//  If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
//  
//  The replacement must be in-place, do not allocate extra memory.
//  
//  Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
//  1,2,3 → 1,3,2
//  3,2,1 → 1,2,3
//  1,1,5 → 1,5,1

public class Solution {
		public void NextPermutation(int[] nums)
        {
            int swapPoint = nums.Length - 1;

            while (swapPoint > 0 && nums[swapPoint - 1] >= nums[swapPoint])
            {
                swapPoint--;
            }

            if (swapPoint != 0)
            {
                int swapPointRight = nums.Length - 1;
                while (swapPointRight >= swapPoint && nums[swapPointRight] <= nums[swapPoint - 1])
                {
                    swapPointRight--;
                }
                this.Swap(nums, swapPoint - 1, swapPointRight);
            }

            this.ReverseSort(nums, swapPoint, nums.Length - 1);
        }

        private void Swap(int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        private void ReverseSort(int[] nums, int start, int end)
        {
            for (int i = 0; i < (end - start) / 2 + 1; i++)
            {
                this.Swap(nums, start + i, end - i);
            }
        }
}