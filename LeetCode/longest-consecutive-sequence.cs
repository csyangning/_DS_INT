//  https://leetcode.com/problems/longest-consecutive-sequence/
//  
//  Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
//  
//  For example,
//  Given [100, 4, 200, 1, 3, 2],
//  The longest consecutive elements sequence is [1, 2, 3, 4]. Return its length: 4.
//  
//  Your algorithm should run in O(n) complexity.

public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> hash = new Dictionary<int, int>();
		int result = 0;
		
		foreach(int num in nums)
		{
			if(!hash.ContainsKey(num))
			{
				int left = hash.ContainsKey(num - 1) ? hash[num - 1] : 0;
				int right = hash.ContainsKey(num + 1) ? hash[num + 1] : 0;
				
				int newLength = left + right + 1;
				hash.Add(num, newLength);
				result = Math.Max(result, newLength);
				
				if(left != 0)
				{
					hash[num - left] = newLength;
				}
				
				if(right != 0)
				{
					hash[num + right] = newLength;
				}
			}
		}
		
		return result;
    }
}