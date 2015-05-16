// https://leetcode.com/problems/search-in-rotated-sorted-array/

// Suppose a sorted array is rotated at some pivot unknown to you beforehand.
// 
// (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
// 
// You are given a target value to search. If found in the array return its index, otherwise return -1.
// 
// You may assume no duplicate exists in the array.
public class Solution {
    public int Search(int[] nums, int target)
        {

            if (nums == null)
            {
                return -1;
            }

            int turningPointer = FindTurningPoint(nums);

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                int realMiddle = (middle + turningPointer) % nums.Length;

                if (nums[realMiddle] == target)
                {
                    return realMiddle;
                }
                else if (nums[realMiddle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }


            return -1;
        }

        private int FindTurningPoint(int[] nums)
        {
            int index1 = 0;
            int index2 = nums.Length - 1;
            int middle = 0;

            while (index1 < index2)
            {
                middle = (index1 + index2) / 2;

                if (nums[middle] > nums[index2])
                {
                    index1 = middle + 1;
                }
                else
                {
                    index2 = middle;
                }
            }

            return index1;
        }
}