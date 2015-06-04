// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
// 
// Follow up for "Remove Duplicates":
// What if duplicates are allowed at most twice?
// 
// For example,
// Given sorted array nums = [1,1,1,2,2,3],
// 
// Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3. It doesn't matter what you leave beyond the new length.

public class Solution {
    public int RemoveDuplicates(int[] nums) {

        if(nums == null || nums.Length == 0)
		{
			return 0;
		}
		
		int numsToRemove = 0;
		int preValue = nums[0];
		int index = 1;
		bool canTake = true;
        
		for(int i = 1; i < nums.Length; i++)
		{
			if(nums[i] == preValue)
			{
                if(canTake)
                {
                    nums[index++] = nums[i];    
                    canTake = false;   
                }
                else
                {
				    numsToRemove++;
                }
			}
			else
			{
				preValue = nums[i];
                canTake = true;
				nums[index++] = nums[i];
			}
		}
		
		return nums.Length - numsToRemove;
    }
}