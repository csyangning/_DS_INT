// https://leetcode.com/problems/count-primes/
// Description:
// 
// Count the number of prime numbers less than a non-negative number, n.

public class Solution {
    public int CountPrimes(int n) {
		if(n <= 2)
		{
			return 0;
		}
		
		List<int> primes = new List<int>();
		primes.Add(2);
		
		for(int i = 3; i < n; i ++)
		{
			bool isPrime = true;
			
			for(int j = 0; j < primes.Count && primes[j] <= Math.Sqrt(i); j++)
			{
				if(i % primes[j] == 0)
				{
					isPrime = false;
					break;
				}
			}
			
			if(isPrime)
			{
				primes.Add(i);
			}
		}
        
		return primes.Count;
    }
}