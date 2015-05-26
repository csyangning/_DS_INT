// https://leetcode.com/problems/combination-sum/

// Given a set of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
// 
// The same repeated number may be chosen from C unlimited number of times.
// 
// Note:
// All numbers (including target) will be positive integers.
// Elements in a combination (a1, a2, … , ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
// The solution set must not contain duplicate combinations.
// For example, given candidate set 2,3,6,7 and target 7, 
// A solution set is: 
// [7] 
// [2, 2, 3] 

public class Solution {
    public List<List<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);
		return CombinationSum(candidates, 0, target);

    }
	
	private List<List<int>> CombinationSum(int[] candidates, int startIndex, int target) {
		List<List<int>> result = new List<List<int>>();
		
		for(int i = startIndex; i < candidates.Length; i++)
		{
			if(target < candidates[i])
			{
				break;
			}
			else if(target == candidates[i])
			{
				List<int> node = new List<int>();
				node.Add(candidates[i]);
				result.Add(node);
			}
			else
			{
				foreach(List<int> r in CombinationSum(candidates, i, target - candidates[i]))
				{
					r.Insert(0,candidates[i])
					result.Add(r);
				}
			}
			
		}
		
		return result;
	}
}