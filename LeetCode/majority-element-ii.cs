//  https://leetcode.com/problems/majority-element-ii/
//  
//  G ay of size n, find all elements that appear more than ⌊ n/3 ⌋ times. The algorithm should run in linear time and in O(1) space.

//  https://leetcode.com/problems/majority-element-ii/
//  
//  G ay of size n, find all elements that appear more than ⌊ n/3 ⌋ times. The algorithm should run in linear time and in O(1) space.

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int majority1 = 0;
		int majority2 = 1;
		int count1 = 0;
		int count2 = 0;
		
		foreach (int num in nums)
		{

		    if(num == majority1)
			{
				count1++;
			}
			else if(num == majority2)
			{
				count2++;
			}
			else if (count1 == 0)
			{
				majority1 = num;
				count1 = 1;
			}
			else if(count2 == 0)
			{
				majority2 = num;
				count2 = 1;
			}
			else
			{
				count1--;
				count2--;
			}
		}
		
		List<int> result = new List<int>();
		
		
		int c1 = 0;
		int c2 = 0;
		foreach(int n in nums)
		{
		    if(n == majority1)
		    {
		        c1++;
		    }
		    
		    if(n == majority2)
		    {
		        c2++;
		    }
		}
		
		if(c1 > nums.Length / 3)
		{
			result.Add(majority1);
		}
		
		if(c2 > nums.Length / 3)
		{
			result.Add(majority2);
		}
		
		return result;
    }
}