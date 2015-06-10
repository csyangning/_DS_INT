//  https://leetcode.com/problems/remove-linked-list-elements/
//  
//  Remove all elements from a linked list of integers that have value val.
//  
//  Example
//  Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
//  Return: 1 --> 2 --> 3 --> 4 --> 5

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode tmp = new ListNode(0);
		tmp.next = head;
		ListNode travelNode = tmp;
		while(travelNode.next != null)
		{
			if(travelNode.next.val == val)
			{
				travelNode.next = travelNode.next.next;
			}
			else
			{
				travelNode = travelNode.next;
			}
		}
		
		return tmp.next;
    }
}