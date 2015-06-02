// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
// 
// Given preorder and inorder traversal of a tree, construct the binary tree.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    private int index = 0;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return BuildTree(preorder, inorder, 0, inorder.Length - 1);
    }

    public TreeNode BuildTree(int[] preorder, int[] inorder, int left, int right)
    {

        if (left > right)
        {
            return null;
        }

        if (left == right)
        {
            return new TreeNode(preorder[index++]);
        }

        int rootIndex = FindRootIndex(inorder, left, right, preorder[index]);
        TreeNode node = new TreeNode(preorder[index++]);
        node.left = BuildTree(preorder, inorder, left, rootIndex - 1);
        node.right = BuildTree(preorder, inorder, rootIndex + 1, right);

        return node;
    }

    private int FindRootIndex(int[] inorder, int left, int right, int target)
    {
        for (int i = left; i <= right; i++)
        {
            if (inorder[i] == target)
            {
                return i;
            }
        }

        return -1;
    }
}