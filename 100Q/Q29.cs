// 29. Maximums in Sliding Windows

// Question: Given an array of numbers and a sliding window size, how to get the maximal numbers in all sliding windows?

public List<int> MaxInSlidingWindow(int[] values, int windowSize)
{
	List<int> result = new List<int>();
	
	if(values.Length >= windowSize && windowSize > 1)
	{
		LinkedList<int> maxQueue = new LinkedList<int>();
		
		for(int i = 0; i < windowSize; i++)
		{
			while(maxQueue.Count != 0 && values[maxQueue.Last] < values[i])
			{
				maxQueue.RemoveLast()
			}
			
			maxQueue.AddLast(i);
		}
		
		result.Add(values[maxQueue.First]);
		
		for(int i = windowSize; i < values.Length; i++)
		{
			while(maxQueue.Count != 0 && values[maxQueue.Last] < values[i])
			{
				maxQueue.RemoveLast()
			}
			
			maxQueue.AddLast(value[i]);
			
			if((i - maxQueue.First) > windowSize)
			{
				maxQueue.RemoveFirst();
			}
			
			result.Add(values[maxQueue.First]);
		}
	}
	
	return result;
}