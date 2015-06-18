//  https://leetcode.com/problems/binary-tree-level-order-traversal/
//  Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
//  
//  For example:
//  Given binary tree {3,9,20,#,#,15,7},
//      3
//     / \
//    9  20
//      /  \
//     15   7
//  return its level order traversal as:
//  [
//    [3],
//    [9,20],
//    [15,7]
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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
		List<List<int>> result = new List<List<int>>();
		
		if(root == null)
		{
			return result;
		}
		
		Queue<TreeNode> queue = new Queue<TreeNode>();
		
		queue.Enqueue(root);
		
		while(queue.Count != 0)
		{
			Queue<TreeNode> nextQueue = new Queue<TreeNode>();
			List<int> resultSet = new List<int>();
			
			while(queue.Count != 0)
			{
				TreeNode node = queue.Dequeue();
				resultSet.Add(node.val);
								
				if(node.left != null)
				{
					nextQueue.Enqueue(node.left);
				}
				
			    if(node.right != null)
				{
					nextQueue.Enqueue(node.right);
				}

			}
			
			result.Add(resultSet);
			queue = nextQueue;
		}
		
		return result;
    }
}