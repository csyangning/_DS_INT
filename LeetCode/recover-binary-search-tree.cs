// https://leetcode.com/problems/recover-binary-search-tree/
// 
// Two elements of a binary search tree (BST) are swapped by mistake.
// 
// Recover the tree without changing its structure.
// 
// Note:
// A solution using O(n) space is pretty straight forward. Could you devise a constant space solution?
// confused what "{1,#,2,3}" means? > read more on how binary tree is serialized on OJ.

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
    private TreeNode firstElement;
    private TreeNode secondElement;
    private TreeNode preElement = new TreeNode(int.MinValue);
    
    public void RecoverTree(TreeNode root) {
        TravelTree(root);
        
        if(firstElement == null || secondElement == null)
        {
            return;
        }
        else
        {
            int tmp = firstElement.val;
            firstElement.val = secondElement.val;
            secondElement.val = tmp;
        }
        
    }
    
    private void TravelTree(TreeNode root)
    {
        if(root == null)
        {
            return;
        }
        
        TravelTree(root.left);
        
        if(firstElement == null && preElement.val > root.val)
        {
            firstElement = preElement;
        }
        
        if(firstElement != null && preElement.val > root.val)
        {
            secondElement = root;
        }
        
        preElement = root;
        
        TravelTree(root.right);
    }
}