//  https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
//  
//  Given a binary tree, return the zigzag level order traversal of its nodes' values. (ie, from left to right, then right to left for the next level and alternate between).
//  
//  For example:
//  Given binary tree {3,9,20,#,#,15,7},
//      3
//     / \
//    9  20
//      /  \
//     15   7
//  return its zigzag level order traversal as:
//  [
//    [3],
//    [20,9],
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
 
 public class Solution {
    public List<List<int>> ZigzagLevelOrder(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        
        if(root == null)
        {
            return result;
        }
        
        Stack<TreeNode> layer = new Stack<TreeNode>();
        layer.Push(root);
        bool leftToRight = true;
        
        while(layer.Count != 0)
        {
            List<int> curretLayerResult = new List<int>();
            Stack<TreeNode> nextLayer = new Stack<TreeNode>();
            
            while(layer.Count != 0)
            {
                TreeNode node = layer.Pop();
                curretLayerResult.Add(node.val);
                
                if(leftToRight)
                {
                    if(node.left != null) nextLayer.Push(node.left); 
                    if(node.right != null) nextLayer.Push(node.right);
                }
                else
                {
                    if(node.right != null) nextLayer.Push(node.right);
                    if(node.left != null) nextLayer.Push(node.left); 
                }
            }
            
            result.Add(curretLayerResult);
            layer = nextLayer;
            leftToRight = !leftToRight;
        }
        
        return result;
    }
}

-------------------------------------------------------------
 
public class Solution {
    public List<List<int>> ZigzagLevelOrder(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        
        if(root == null)
        {
            return result;
        }
        
        LinkedList<TreeNode> layer = new LinkedList<TreeNode>();
        layer.AddFirst(root);
        bool leftToRight = true;
        
        while(layer.Count != 0)
        {
            List<int> curretLayerResult = new List<int>();
            LinkedList<TreeNode> nextLayer = new LinkedList<TreeNode>();
            
            foreach(TreeNode node in layer)
            {
                curretLayerResult.Add(node.val);
                
                if(leftToRight)
                {
                    if(node.left != null) nextLayer.AddFirst(node.left); 
                    if(node.right != null) nextLayer.AddFirst(node.right);
                }
                else
                {
                    if(node.right != null) nextLayer.AddFirst(node.right);
                    if(node.left != null) nextLayer.AddFirst(node.left); 
                }
            }
            
            result.Add(curretLayerResult);
            layer = nextLayer;
            leftToRight = !leftToRight;
        }
        
        return result;
    }
}