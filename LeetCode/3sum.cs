// https://leetcode.com/problems/3sum/


// Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.
// 
// Note:
// Elements in a triplet (a,b,c) must be in non-descending order. (ie, a ≤ b ≤ c)
// The solution set must not contain duplicate triplets.

public class Solution
  {
      public List<List<int>> ThreeSum(int[] nums)
      {
          Array.Sort(nums);

          List<List<int>> result = new List<List<int>>();

          for (int i = 0; i < nums.Length - 2; i++)
          {
              int low = i + 1;
              int hi = nums.Length - 1;

              if (i > 0 && nums[i] == nums[i - 1])
              {
                  continue;
              }

              while (low < hi)
              {
                  int sum = nums[low] + nums[i] + nums[hi];
                  if (sum > 0)
                  {
                      hi--;
                  }
                  else if (sum < 0)
                  {
                      low++;
                  }
                  else
                  {
                      List<int> r = new List<int> {nums[i], nums[low], nums[hi]};
                      result.Add(r);
                      while (low < hi && nums[low] == nums[low+1])
                      {
                          low++;
                      }
                      while (low < hi && nums[hi] == nums[hi - 1])
                      {
                          hi--;
                      }
                      low++;
                      hi--;
                  }
              }

          }

          return result;
      }
  }