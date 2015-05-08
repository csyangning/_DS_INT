
// 11. Implement a function to reverse a linked list, and return the head of the reversed list.

internal class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public static ListNode RevertList(ListNode header)
    {
        if (header == null)
        {
            return null;
        }

        ListNode preNode = null;
        ListNode currentNode = header;
        ListNode nextNode = currentNode.Next;

        while (nextNode != null)
        {
            currentNode.Next = preNode;
            preNode = currentNode;
            currentNode = nextNode;
            nextNode = nextNode.Next;
        }

        currentNode.Next = preNode;

        return currentNode;
    }
}