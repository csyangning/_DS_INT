//  https://leetcode.com/problems/path-sum-ii/
//  
//  Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
//  
//  For example:
//  Given the below binary tree and sum = 22,
//                5
//               / \
//              4   8
//             /   / \
//            11  13  4
//           /  \    / \
//          7    2  5   1
//  return
//  [
//     [5,4,11,2],
//     [5,8,4,5]
//  ]

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 
 
 // improved version
 
 public class Solution {
    public List<List<int>> PathSum(TreeNode root, int sum) {
		
        List<List<int>> result = new List<List<int>>();
        List<int> currentPath = new List<int>();
        
        if(root != null)
        {
            PathSum(root, sum, currentPath, result); 
        }
        
		return result;
    }
    
    private void PathSum(TreeNode root, int sum, List<int> currentPath, List<List<int>> result)
    {
        if(root == null)
        {
            return;
        }
        
        currentPath.Add(root.val);
        
        if(root.left == null && root.right == null && root.val == sum)
		{
            result.Add(new List<int>(currentPath));
		}
        else
        {
            int remainingSum = sum - root.val;
            PathSum(root.left, remainingSum, new List<int>(currentPath), result);
            PathSum(root.right, remainingSum, new List<int>(currentPath), result);

        }
        
        currentPath.RemoveAt(currentPath.Count - 1);
    }
}

// old

public class Solution {
    public List<List<int>> PathSum(TreeNode root, int sum) {
		
        List<List<int>> result = new List<List<int>>();
        List<int> currentPath = new List<int>();
        
        if(root != null)
        {
            PathSum(root, sum, currentPath, result); 
        }
        
		return result;
    }
    
    private void PathSum(TreeNode root, int sum, List<int> currentPath, List<List<int>> result)
    {
        if(root.left == null && root.right == null)
		{
			if(root.val == sum)
			{
				currentPath.Add(root.val);
                result.Add(new List<int>(currentPath));
			}
		}
        else
        {
            currentPath.Add(root.val);
            int remainingSum = sum - root.val;
            
            if(root.left != null)
            {
                PathSum(root.left, remainingSum, new List<int>(currentPath), result);
            }
            
            if(root.right != null)
            {
                PathSum(root.right, remainingSum, new List<int>(currentPath), result);
            }
        }
        
        currentPath.RemoveAt(currentPath.Count - 1);
    }
}