//  https://leetcode.com/problems/swap-nodes-in-pairs/
//  
//  Given a linked list, swap every two adjacent nodes and return its head.
//  
//  For example,
//  Given 1->2->3->4, you should return the list as 2->1->4->3.
//  
//  Your algorithm should use only constant space. You may not modify the values in the list, only nodes itself can be changed.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode tmp = new ListNode(0);
        tmp.next = head;
        ListNode travelNode = tmp;
        
        while(travelNode.next != null && travelNode.next.next != null)
        {
            ListNode second = travelNode.next.next;
            travelNode.next.next = second.next;
            second.next = travelNode.next;
            travelNode.next = second;
            travelNode = travelNode.next.next;
        }
        
        return tmp.next;
    }
}