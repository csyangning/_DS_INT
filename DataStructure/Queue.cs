class Queue
{
	Node first, last;
	
	void enqueue(object item)
	{
		Node node = new Node(item)
		if(fisrt == null)
		{
			this.first = this.last = node;
		}
		else
		{
			this.last.next = node;
			this.last = node;
		}

	}
	
	object dequeue(object item)
	{
		if(this.first == null)
		{
			return null;
		}
		else
		{
			Node node = this.first;
			this.first = this.first.Next;
			return node.Value;
		}
	}
}