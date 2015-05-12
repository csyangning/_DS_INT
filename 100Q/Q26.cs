// 26. Stack with Function min()

// Problem: Define a stack, in which we can get its minimum number with a function min. 
// In this stack, the time complexity of min(), push() and pop() are all O(1).

public class StackWithMin<T>
{
	private Stack<T> dataStack;
	private Stack<T> minStack;
	
	public StackWithMin()
	{
		this.dataStack = new Stack<T>();
		this.minStack = new Stack<T>();
	}
	
	public void Push(T value)
	{
		this.dataStack.Push(value);
		if(minStack.Count == 0 || value < minStack.Peek())
		{
			minStack.Push(value);
		}
		else
		{
			minStack.Push(minStack.Peek());
		}
	}
	
	public T Pop()
	{
		this.minStack.Pop();
		return this.dataStack.Pop();
	}
	
	public T Min()
	{
		return this.minStack.Peek();
	}
}