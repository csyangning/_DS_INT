// https://leetcode.com/problems/subsets/
// 
// Given a set of distinct integers, nums, return all possible subsets.
// 
// Note:
// Elements in a subset must be in non-descending order.
// The solution set must not contain duplicate subsets.
// For example,
// If nums = [1,2,3], a solution is:
// 
// [
//   [3],
//   [1],
//   [2],
//   [1,2,3],
//   [1,3],
//   [2,3],
//   [1,2],
//   []
// ]

public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        Array.Sort(nums);
        int count = (int)Math.Pow(2, nums.Length);
        List<List<int>> result = new List<List<int>>();
        for(int i = 0; i<count; i++)
        {
            result.Add(new List<int>());
        }
        
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < count; j++ )
            {
                if(((j >> i) & 1) == 1)
                result[j].Add(nums[i]);
            }
        }
        
        return result;
    }
}