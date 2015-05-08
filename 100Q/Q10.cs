// 10. Problem: Get the Kth node from end of a linked list. It counts from 1 here, so the 1st node from end is the tail of list.

//For instance, given a linked list with 6 nodes, whose value are 1, 2, 3, 4, 5, 6, its 3rd node from end is the node with value 4.

internal class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public static ListNode FindKthToTail(ListNode header, int k)
    {
        if (header == null || k <= 0)
        {
            return null;
        }

        ListNode P1 = header;
        for (int i = 0; i < k-1; i++)
        {
            if (P1.Next != null)
            {
                P1 = P1.Next;
            }
            else
            {
                return null;
            }
        }

        ListNode P2 = header;

        while (P1.Next != null)
        {
            P1 = P1.Next;
            P2 = P2.Next;
        }

        return P2;
    }
}