// https://leetcode.com/problems/3sum-closest/

// Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target.
// Return the sum of the three integers. You may assume that each input would have exactly one solution.
// 
//     For example, given array S = {-1 2 1 -4}, and target = 1.
// 
//     The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

  public class Solution
  {
      public int ThreeSumClosest(int[] nums, int target)
      {
          Array.Sort(nums);
          int closestSum = int.MaxValue;

          for (int i = 0; i < nums.Length - 2; i++)
          {
              int low = i + 1;
              int hi = nums.Length - 1;

              while (low < hi)
              {
                  int currentSum = nums[i] + nums[low] + nums[hi];
                  if (Math.Abs((long)currentSum - (long)target) < Math.Abs((long)closestSum - (long)target))
                  {
                      closestSum = currentSum;
                  }

                  if (currentSum < target)
                  {
                      low++;
                  }
                  else if (currentSum > target)
                  {
                      hi--;
                  }
                  else
                  {
                      return closestSum;
                  }
              }
          }

          return closestSum;
      }
  }