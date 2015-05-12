// 37. Maximum Sum of All Sub-arrays
// Question: A sub-array has one number of some continuous numbers. Given an integer array
// with positive numbers and negative numbers, get the maximum sum of all sub-arrays. Time
//  complexity should be O(n).
// For example, in the array {1, -2, 3, 10, -4, 7, 2, -5}, its sub-array {3, 10, -4, 7, 2} has the
// maximum sum 18

public int FindMaxSum(int[] numbers)
{
	int currentSum = 0;
	int maxSum = int.MinValue;
	
	foreach(number in numbers)
	{
		if(currentSum <= 0)
		{
			currentSum = number;
		}
		else
		{
			currentSum += number;
		}
		
		if(currentSum > maxSum)
		{
			maxSum = currentSum;
		}
	}
	
	return maxSum;
}