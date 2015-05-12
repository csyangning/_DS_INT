// 34. Given an array of integers, find two numbers such that they add up to a specific target
// number.

public int[] twoSum(int[] numbers, int target)
{
	Dictionary<int, int> map = new Dictionary<int, int>();
	int[] result = new int[2];
	
	for(int i = 0; i < numbers.Length; i++)
	{
		if(map.ContainKey(numbers[i]))
		{
			result[0] = map[numbers[i]] + 1;
			result[1] = i +1;
			break;
		}
		else
		{
			map.Add(target - number[i], i);
		}
	}
	
	return result;
}