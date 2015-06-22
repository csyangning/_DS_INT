//  https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
//  
//  Given an array where elements are sorted in ascending order, convert it to a height balanced BST.

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
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums == null || nums.Length == 0)
        {
            return null;
        }
        
        return ConvertBST(nums, 0, nums.Length - 1);
    }
    
    private TreeNode ConvertBST(int[] nums, int start, int end)
    {
        if(start == end)
        {
            return new TreeNode(nums[start]);
        }
        
        int middle = (start + end) / 2;
        TreeNode root = new TreeNode(nums[middle]);
        
        if(middle < end)
        {
            root.right = ConvertBST(nums, middle + 1, end);
        }
        
        if(middle > start)
        {
            root.left = ConvertBST(nums, start, middle - 1);
        }
        
        return root;
    }
}