//  https://leetcode.com/problems/reverse-linked-list-ii/
//  
//  Reverse a linked list from position m to n. Do it in-place and in one-pass.
//  
//  For example:
//  Given 1->2->3->4->5->NULL, m = 2 and n = 4,
//  1->3->2->4->5
//  return 1->4->3->2->5->NULL.
//  
//  Note:
//  Given m, n satisfy the following condition:
//  1 ≤ m ≤ n ≤ length of list.


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        if(head == null || head.next == null || m == n)
        {
            return head;
        }
        
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode pre = dummy;
        
        for(int i = 1; i < m; i++) pre = pre.next;
        
        ListNode current = pre.next;
        ListNode next = current.next;
        
        for(int i = 0; i < n - m; i++)
        {
            current.next = next.next;
            next.next = pre.next;
            pre.next = next;
            next = current.next;
        }
        
        return dumy.next;
    }
 }
 
 
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        if(m == n)
        {
            return head;
        }
        
        ListNode revertHead = null;
        int count = n - m;
        ListNode startNode = null;
        
        if(m != 1)
        {
            revertHead = head;
            while(--m > 1) revertHead = revertHead.next;
            startNode = revertHead.next;
        }
        else
        {
            startNode = head;
        }
        
        
        ListNode currentNode = startNode;
        ListNode nextNode = currentNode.next;
        while(count-- > 0)
        {
            ListNode tmp = nextNode;
            nextNode = nextNode.next;
            tmp.next = currentNode;
            currentNode = tmp;
        }
        
        startNode.next = nextNode;
        
        if(revertHead != null)
        {
            revertHead.next = currentNode;
            return head;        
        }
        else
        {
            return currentNode;
        }
        
    }
}