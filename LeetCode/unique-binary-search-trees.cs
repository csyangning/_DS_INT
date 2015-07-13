//  https://leetcode.com/problems/unique-binary-search-trees/
//  
//  Given n, how many structurally unique BST's (binary search trees) that store values 1...n?
//  
//  For example,
//  Given n = 3, there are a total of 5 unique BST's.
//  
//     1         3     3      2      1
//      \       /     /      / \      \
//       3     2     1      1   3      2
//      /     /       \                 \
//     2     1         2                 3

///////////////DP WAY////////////////////////////////

 public class Solution
 {
      public int NumTrees(int n)
      {
          int[] result = new int[n + 1];
          result[0] = result[1] = 1;
          
          for (int i = 2; i <= n; i++)
          {
              for(int j = 0; j < i; j++)
              {
                  result[i] += result[j]*result[i - j - 1];
              }
          }
          
          return result[n];
      }
 }
 
////////////////RECURSIVE WAY/////////////////////
  public class Solution
  {
      private Dictionary<int, int> hashTable = new Dictionary<int, int>(); 
      public int NumTrees(int n)
      {
          if (n == 0)
          {
              return 1;
          }

          int result = 0;

          for (int i = 0; i < n; i++)
          {
              int left = GetCombination(i);
              int right = GetCombination(n - i - 1);
              result += left * right;
          }

          return result;
      }

      private int GetCombination(int n)
      {
          if (!hashTable.ContainsKey(n))
          {
              hashTable.Add(n, NumTrees(n));
          }

          return hashTable[n];
      }
  }