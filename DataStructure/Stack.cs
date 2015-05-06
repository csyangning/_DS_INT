class Stack
{
    Node top;
    
    Object pop()
    {
        if(top != null)
        {
            Node node = top;
            top = top.Next;
            return node.Value;
        }
        
        return null;
    }
    
    void push(Object item)
    {
        Node node = new Node(item);
        node.next = top;
        top = node;
    }
    
    Object peek()
    {
        return top.Value;
    }
}
