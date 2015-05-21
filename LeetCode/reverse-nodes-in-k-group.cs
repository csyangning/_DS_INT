// https://leetcode.com/problems/reverse-nodes-in-k-group/
// 
// Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.
// 
// If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.
// 
// You may not alter the values in the nodes, only nodes itself may be changed.
// 
// Only constant memory is allowed.
// 
// For example,
// Given this linked list: 1->2->3->4->5
// 
// For k = 2, you should return: 2->1->4->3->5
// 
// For k = 3, you should return: 3->2->1->4->5

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
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k <= 1)
            {
                return head;
            }

            ListNode tempHead = new ListNode(0);
            ListNode prevEnd = tempHead;
            prevEnd.next = head;

            while (prevEnd != null)
            {
                ListNode revertHeader = ReverseList(prevEnd.next, k);
                prevEnd.next = revertHeader;

                for (int i = 0; i < k && prevEnd != null; i++)
                {
                    prevEnd = prevEnd.next;
                }
            }

            return tempHead.next;
        }

        private ListNode ReverseList(ListNode head, int length)
        {
            if (head == null)
            {
                return null;
            }
            int l = length;
            ListNode h = head;

            while (--l > 0)
            {
                h = h.next;
                if (h == null)
                {
                    return head;
                }
            }

            ListNode currentH = head;
            ListNode currentNode = head;
            ListNode nextNode = head.next;

            for (int i = 1; i < length; i++)
            {
                ListNode temp = nextNode;
                nextNode = nextNode.next;
                temp.next = currentNode;
                currentNode = temp;
            }

            currentH.next = nextNode;
            return currentNode;
        }
    }