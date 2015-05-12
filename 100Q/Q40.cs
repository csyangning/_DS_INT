// Number of 1 in a Binary

// Problem: Please implement a function to get the number of 1s in an integer. For example, the
// integer 9 is 1001 in binary, so it returns 2 since there are two bits of 1s.

public int NumberOfOnes(int n)
{
	int count = 0;
	
	while(n != 0)
	{
		count += n % 2;
		n = n /2;
	}
	
	return count;
}

// better
int NumberOf1(int n)
{
	int count = 0;
	unsigned int flag = 1;
	
	while(flag)
	{
		if(n & flag)
			count ++;
		flag = flag << 1;
	}
	
	return count;
}