// 33. Merge two sorted linked lists and return it as a new list.

internal class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }

	public ListNode MergeList(ListNode head1, ListNode head2)
	{
		ListNode newList = new ListNode();
		ListNode p = newList;
		ListNode p1 = head1;
		ListNode p2 = head2;
		
		while(p1 != null && p2 != null)
		{
			if(p1.Value < p2.Valule)
			{
				p.Next = p1;
				p1 = p1.next;
			}
			else
			{
				p.Next = p2;
				p2 = p2.next;
			}
			
			p = p.next;
		}
		
		if(p1 != null)
		{
			p.Next = p1;
		}
		
		if(p2 != null)
		{
			p.Next = p2;
		}
		
		return newList.Next;
	}
}