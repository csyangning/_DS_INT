//  https://leetcode.com/problems/subsets-ii/
//  
//  Given a collection of integers that might contain duplicates, nums, return all possible subsets.
//  
//  Note:
//  Elements in a subset must be in non-descending order.
//  The solution set must not contain duplicate subsets.
//  For example,
//  If nums = [1,2,2], a solution is:
//  
//  [
//    [2],
//    [1],
//    [1,2,2],
//    [2,2],
//    [1,2],
//    []
//  ]

public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();
        result.Add(new List<int>());
        
        for(int i = 0; i < nums.Length;)
        {
            int count = 1;
            while(count + i < nums.Length && nums[count + i] == nums[i]) count++;
            
            int currentResultSize = result.Count;
            for(int j = 0; j < currentResultSize; j++)
            {
                List<int> currentResult = new List<int>(result[j]);
                for(int k = 0; k < count; k++)
                {
                    currentResult.Add(nums[i]);
                    result.Add(new List<int>(currentResult));
                }
                
            }
            
            i += count;
        }
        
        return result;
    }
}