//  https://leetcode.com/problems/combination-sum-ii/
//  
//  Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
//  
//  Each number in C may only be used once in the combination.
//  
//  Note:
//  All numbers (including target) will be positive integers.
//  Elements in a combination (a1, a2, … , ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
//  The solution set must not contain duplicate combinations.
//  For example, given candidate set 10,1,2,7,6,1,5 and target 8, 
//  A solution set is: 
//  [1, 7] 
//  [1, 2, 5] 
//  [2, 6] 
//  [1, 1, 6] 

public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();
        CombinationSum2(0, target, candidates, current, result);
        return result;
    }
    
    private void CombinationSum2(int startIndex, int target, int[] candidates, List<int> current, List<List<int>> result)
    {
        if(target == 0)
        {
            result.Add(new List<int>(current));
        }
        
        for(int i = startIndex; i < candidates.Length; i++)
        {
            if(candidates[i] > target)
            {
                break;
            }
        
            if(i > startIndex && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            current.Add(candidates[i]);
            CombinationSum2(i + 1, target - candidates[i], candidates, current, result);
            current.RemoveAt(current.Count - 1);            
        }
    }
}

-----------------------------------------------------------------

public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        return CombinationSum2(0, target, candidates);
    }
    
    private List<List<int>> CombinationSum2(int startIndex, int target, int[] candidates)
    {
        List<List<int>> result = new List<List<int>>();
        
        for(int i = startIndex; i < candidates.Length; i++)
        {
            if(candidates[i] > target)
            {
                break;
            }
        
            if(i > startIndex && candidates[i] == candidates[i - 1])
            {
                continue;
            }
            
                
            if(candidates[i] == target)
            {
                List<int> node = new List<int>();
                node.Add(candidates[i]);
                result.Add(node);
            }
            else
            {
 
                foreach(List<int> r in CombinationSum2(i + 1, target - candidates[i], candidates))
                {
                    r.Insert(0, candidates[i]);
                    result.Add(r);
                }
            }
        }
        
        return result;
    }
}