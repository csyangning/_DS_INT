//  https://leetcode.com/problems/reverse-linked-list/
//  
//  Reverse a singly linked list.

public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null)
        {
            return head;
        }
        
        ListNode currentNode = head;
        ListNode nextNode = head.next;
        
        while(nextNode != null)
        {
            ListNode tmp = nextNode;
            nextNode = tmp.next;
            tmp.next = currentNode;
            currentNode = tmp;
        }
        
        head.next = null;
        
        return currentNode;
    }
}


public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode newHead = null;
        while(head != null)
        {
            ListNode next = head.next;
            head.next = newHead;
            newHead = head;
            head = next;
        }
        
        return newHead;
    }
}