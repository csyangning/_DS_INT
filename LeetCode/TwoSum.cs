// https://leetcode.com/problems/two-sum/
// 
// Given an array of integers, find two numbers such that they add up to a specific target number.
// 
// The function twoSum should return indices of the two numbers such that they add up to the target, 
// where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
// 
// You may assume that each input would have exactly one solution.
// 
// Input: numbers={2, 7, 11, 15}, target=9
// Output: index1=1, index2=2

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if (nums == null)
        {
            return null;
        }
        
        Dictionary<int, int> hashTable = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(hashTable.ContainsKey(nums[i]))
            {
                int[] result = new int[2];
                result[0] = hashTable[nums[i]] + 1;
                result[1] = i + 1;
                return result;
            }
            else
            {
                if(!hashTable.ContainsKey(target - nums[i]))
                {
                    hashTable.Add(target - nums[i], i);
                }
            }
        }
        
        return null;
    }
}