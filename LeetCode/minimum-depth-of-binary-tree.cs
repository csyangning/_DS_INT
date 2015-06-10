//  https://leetcode.com/problems/minimum-depth-of-binary-tree/
//  
//  Given a binary tree, find its minimum depth.
//  
//  The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

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
    public int MinDepth(TreeNode root) {
        if(root == null)
		{
			return 0;
		}
		
		int depth = 0;
		Stack<TreeNode> nextStack = new Stack<TreeNode>();
		nextStack.Push(root);
		
		while(nextStack.Count != 0)
		{
			depth++;
			Stack<TreeNode> currentStack = new Stack<TreeNode>(nextStack);
			nextStack.Clear();
			
			while(currentStack.Count != 0)
			{
				TreeNode currentNode = currentStack.Pop();
				if(currentNode != root && currentNode.left == null && currentNode.right == null)
				{
					return depth;
				}
				
				if(currentNode.left != null)
				{
					nextStack.Push(currentNode.left);
				}
				
				if(currentNode.right != null)
				{
					nextStack.Push(currentNode.right);
				}
			}
		}
		
		return depth;
    }
}