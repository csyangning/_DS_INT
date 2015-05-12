// 32. Given a sorted linked list, delete all duplicates such that each element appear only once

internal class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public static void RemoveDup(ListNode header)
    {
        if (header == null || header.Next == null)
        {
            return;
        }

        ListNode previousNode = header;
        ListNode currentNode = header.Next;
        while (currentNode != null)
        {
            if (currentNode.Value == previousNode.Value)
            {
                previousNode.Next = currentNode.Next;
            }
            else
            {
                previousNode = currentNode;
            }

            currentNode = currentNode.Next;
        }
    }
}