// 27. Queue Implemented with Two Stacks

// Please implement two functions: appendTail to append an element into tail of a queue, anddeleteHead to delete an element from head of a queue.

public class SQueue<T>
{
	private Stack<T> stack1;
	private Stack<T> stack2;
	
	public SQueue()
	{
		this.stack1 = new Stack<T>();
		this.stack2 = new Stack<T>();
	}
	
	public void appendTail(T value)
	{
		this.stack1.Push(value);
	}
	
	public T deleteHead()
	{
		if(this.stack2.Count == 0)
		{
			while(this.stack1.count != 0)
			{
				this.stack2.Push(this.stack1.Pop());
			}
		}
		
		if(this.stack2.Count == 0)
		{
			return null;
		}
		else
		{
			return this.stack2.Pop();
		}
	}
}