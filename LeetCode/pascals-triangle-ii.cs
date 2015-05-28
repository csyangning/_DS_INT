// https://leetcode.com/problems/pascals-triangle-ii/

// Given an index k, return the kth row of the Pascal's triangle.
// 
// For example, given k = 3,
// Return [1,3,3,1].
// 
// Note:
// Could you optimize your algorithm to use only O(k) extra space?

public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> result = new List<int>();
		
		if(rowIndex < 0)
		{
			return result;
		}
		
		for(int i = 0; i <= rowIndex; i++)
		{
			result.Insert(0,1);
			for(int j = 1; j < result.Count - 1; j++)
			{
				result[j] = result[j] + result[j+1];
			}
		}
		
		return result;
    }
}