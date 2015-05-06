class Node
{
	Public Node Next { get; set; }
	Public int Value { get; set; }

	Public Node (int Value)
	{
		this.Value = Value;
	}

	Public Void Add (Node node)
	{
		Node lastNode = this;

		While(lastNode.Next != null)
		{
			lastNode = lastNode.Next;
		}

		lastNode.Next = node;
	}
}

Node deleteNode(Node head, int d)
{
	Node node = head;
	
	if(node.Value == d)
	{
		head = head.Next;
	}
	
	while(node.Next != null)
	{
		if(node.Next.Value == d)
		{
			node.Next = node.next.next;
			break
		}
		node = node.Next;
	}
	
	return head;
}
