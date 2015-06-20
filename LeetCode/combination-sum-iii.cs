//  https://leetcode.com/problems/combination-sum-iii/
//  
//  Find all possible combinations of k numbers that add up to a number n, 
// given that only numbers from 1 to 9 can be used and each combination should be a unique set of numbers.
//  
//  Ensure that numbers within the set are sorted in ascending order.
//  
//  
//  Example 1:
//  
//  Input: k = 3, n = 7
//  
//  Output:
//  
//  [[1,2,4]]
//  
//  Example 2:
//  
//  Input: k = 3, n = 9
//  
//  Output:
//  
//  [[1,2,6], [1,3,5], [2,3,4]]
//  Credits:
//  Special thanks to @mithmatt for adding this problem and creating all test cases.


public class Solution {
    public List<List<int>> CombinationSum3(int k, int n) {
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();
        CombinationSum3(1, n, current, result, k);
        return result;
    }
    
    private void CombinationSum3(int startIndex, int target, List<int> current, List<List<int>> result, int setSize)
    {
        if(current.Count == setSize)
        {
            if(target == 0)
            {
                result.Add(new List<int>(current));
            }
            else
            {
                return;
            }
        }
        
        for(int i = startIndex; i <= 9; i++)
        {
            if(i > target)
            {
                break;
            }

            current.Add(i);
            CombinationSum3(i + 1, target - i, current, result, setSize);
            current.RemoveAt(current.Count - 1);            
        }
    }
}