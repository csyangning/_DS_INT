//  https://leetcode.com/problems/majority-element/
//  
//  Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
//  
//  You may assume that the array is non-empty and the majority element always exist in the array.
//  
//  Credits:
//  Special thanks to @ts for adding this problem and creating all test cases.


public class Solution {
    public int MajorityElement(int[] nums) {
		int major = nums[0];
		int count = 1;
		
		foreach(int num in nums)
		{
			if(major == num)
			{
				count++;
			}
			else
			{
				count--;
			}
			
			if(count == 0)
			{
				major = num;
				count = 1;
			}
		}
		
		return major;
	}
}


public class Solution {
    public int MajorityElement(int[] nums) {
        int bar = nums.Length / 2;
		Dictionary<int, int> hash = new Dictionary<int, int>();
		
		foreach (int num in nums)
		{
			if (!hash.ContainsKey(num))
			{
				hash.Add(num, 0);
			}
			
			hash[num]++;
			if(hash[num] > bar)
			{
				return num;
			}
		}
		
		return -1;
    }
}