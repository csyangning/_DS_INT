//  https://leetcode.com/problems/sort-list/
//  
//  Sort a linked list in O(n log n) time using constant space complexity.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode SortList(ListNode head) {
        if(head == null ||head.next == null)
        {
            return head;
        }
        
        ListNode sp = head;
        ListNode fp = head.next.next;
        
        while(fp != null && fp.next != null)
        {
            sp = sp.next;
            fp = fp.next.next;
        }
        
        ListNode right = SortList(sp.next);
        sp.next = null;
        ListNode left = SortList(head);
        return Merge(left, right);
    }
    
    private ListNode Merge(ListNode left, ListNode right)
    {
        ListNode head = new ListNode(0);
        ListNode tmp = head;
        
        while(left != null && right != null)
        {
            if(left.val < right.val)
            {
                tmp.next = left;
                left = left.next;
            }
            else
            {
                tmp.next = right;
                right = right.next;
            }
            
            tmp = tmp.next;
        }
        
        if(left == null)
        {
            tmp.next = right;
        }
        
        if(right == null)
        {
            tmp.next = left;
        }
        
        return head.next;
    }
}