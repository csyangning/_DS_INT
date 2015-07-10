//  https://leetcode.com/problems/insertion-sort-list/
//  
//  Sort a linked list using insertion sort.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode InsertionSortList(ListNode head)
    {
        if (head == null)
        {
            return head;
        }

        ListNode tmp = new ListNode(0);
        ListNode current = head;

        while (current != null)
        {
            ListNode nextNode = current.next;
            ListNode travelNode = tmp;
            while (travelNode.next != null && travelNode.next.val < current.val)
            {
                travelNode = travelNode.next;
            }

            current.next = travelNode.next;
            travelNode.next = current;

            current = nextNode;
        }

        return tmp.next;
    }
}