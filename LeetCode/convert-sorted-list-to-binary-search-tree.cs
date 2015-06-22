//  https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
//  
//  Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
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
    private ListNode head;
    
    private int Count(ListNode head)
    {
        int count = 0;
        while(head != null)
        {
            count++;
            head = head.next;
        }
        
        return count;
    }
    
    private TreeNode ConvertBST(int n)
    {
        if(n == 0)
        {
            return null;
        }
        
        TreeNode node = new TreeNode(0);
        node.left = ConvertBST(n/2);
        node.val = head.val;
        head = head.next;
        
        node.right = ConvertBST(n - n/2 - 1);
        return node;
    }
    
    public TreeNode SortedListToBST(ListNode head) {
        this.head = head;
        
        return ConvertBST(this.Count(head));
    }
}