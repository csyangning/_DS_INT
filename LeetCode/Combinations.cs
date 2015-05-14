// https://leetcode.com/problems/combinations/
// 
// Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.
// 
// For example,
// If n = 4 and k = 2, a solution is:
// 
// [
//   [2,4],
//   [3,4],
//   [2,3],
//   [1,2],
//   [1,3],
//   [1,4],
// ]

public class Solution
{
    public List<List<int>> Combine(int n, int k)
    {
        List<List<int>> result = new List<List<int>>();
        int[] path = new int[k];
        CombineCore(n, k, result, path);
        return result;
    }

    private void CombineCore(int n, int k, List<List<int>> result, int[] path)
    {
        if (k == 0)
        {
            result.Add(new List<int>(path));
            return;
        }

        for (int i = n; i > 0; i--)
        {
            path[k - 1] = i;
            CombineCore(i - 1, k - 1, result, path);
        }

    }
}