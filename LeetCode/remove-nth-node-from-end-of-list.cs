// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
//  
//  Given a linked list, remove the nth node from the end of list and return its head.
//  
//  For example,
//  
//     Given linked list: 1->2->3->4->5, and n = 2.
//  
//     After removing the second node from the end, the linked list becomes 1->2->3->5.
//  Note:
//  Given n will always be valid.
//  Try to do this in one pass.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
		
        ListNode pFast = new ListNode(0);
		pFast.next = head;
		ListNode pSlow = new ListNode(0);
		pSlow.next = head;
		
		while(n-- !=0 && pFast.next != null)
		{
			pFast = pFast.next;
		}
		
		while(pFast.next != null)
		{
			pFast = pFast.next;
			pSlow = pSlow.next;
		}
		
		if(pSlow.next == head)
		{
			return head.next;
		}
		else
		{
			pSlow.next = pSlow.next.next;
			return head;
		}
    }
}