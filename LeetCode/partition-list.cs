//  https://leetcode.com/problems/partition-list/
//  
//  Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.
//  
//  You should preserve the original relative order of the nodes in each of the two partitions.
//  
//  For example,
//  Given 1->4->3->2->5->2 and x = 3,
//  return 1->2->2->4->3->5.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode left = new ListNode(0);
		ListNode right = new ListNode(0);
		
		ListNode travelNode = head;
		ListNode tL = left;
		ListNode tR = right;
		
		while (travelNode != null)
		{
			if (travelNode.val < x)
			{
				tL.next = travelNode;
				tL = tL.next;
			}
			else
			{
				tR.next = travelNode;
				tR = tR.next;
			}
			
			travelNode = travelNode.next;
		}
		
		tR.next = null;
		tL.next = right.next;
		
		return left.next;
    }
}