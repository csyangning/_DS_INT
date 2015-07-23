//  https://leetcode.com/problems/largest-number/
//  
//  Given a list of non negative integers, arrange them such that they form the largest number.
//  
//  For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.
//  
//  Note: The result may be very large, so you need to return a string instead of an integer.

  public class Solution
  {
      public string LargestNumber(int[] nums)
      {
          if (nums == null || nums.Length == 0)
          {
              return "0";
          }

          string[] numStrings = new string[nums.Length];

          for (int i = 0; i < nums.Length; i++)
          {
              numStrings[i] = nums[i].ToString();
          }

          Array.Sort(numStrings, (s1, s2) => (s2 + s1).CompareTo(s1 + s2));

          if(numStrings[0] == "0")
          {
              return "0";
          }
          
          return string.Join(string.Empty, numStrings);
      }
  }