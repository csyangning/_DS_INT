// 20. Turning Number in an Array

// Problem: Turning number is the maximum number in an array which increases and then decreases. This kind of array is 
// also named unimodal array. Please write a function which gets the index of the turning number in such an array.

// For example, the turning number in array {1, 2, 3, 4, 5, 10, 9, 8, 7, 6} is 10, so its index 5 is the expected output.

public static int FindTurningIndex(int[] intArray)
{
	if(intArray == null || intArray.Length < 3)
	{
		return -1;
	}
	
	int left = 0;
	int right = intArray.Length - 1;
	
	while(left < right + 1)
	{
		int middle = (left + right) / 2;
		
		// Important!
		if(middle == 0 || middle == intArray.Length -1)
		{
			return -1;
		}
		
		if (intArray[middleIndex] > intArray[middleIndex - 1] &&
        intArray[middleIndex] > intArray[middleIndex + 1])
    	{
			return middle;
		}
		else
		{
			if (intArray[middleIndex] < intArray[middleIndex - 1])
			{
				right = middle;
			}
			else
			{
				left = middle;
			}
		}
	}
	
    return -1
}