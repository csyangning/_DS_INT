// https://leetcode.com/problems/spiral-matrix-ii/

// Given an integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.
// 
// For example,
// Given n = 3,
// 
// You should return the following matrix:
// [
//  [ 1, 2, 3 ],
//  [ 8, 9, 4 ],
//  [ 7, 6, 5 ]
// ]

public class Solution {
    public int[,] GenerateMatrix(int n) {
 		int[,] result =new int[n,n];
		int direction = 0;
		int i = 0;
		int j = 0;
		int k = 1;
		
		while(k <= n*n)
		{
			result[i,j] = k++;
			switch(direction)
			{
				case 0:
				j++;
				if(j == n || result[i,j] != 0)
				{
					direction = 1;
					i++;
					j--;
				}
				break;
				case 1:
				i++;
				if(i == n || result[i,j] != 0)
				{
					direction = 2;
					i--;
					j--;
				}
				break;
				case 2:
				j--;
				if(j < 0 || result[i,j] != 0)
				{
					direction = 3;
					j++;
					i--;
				}
				break;
				case 3:
				i--;
				if(i < 0 || result[i,j] != 0)
				{
					direction = 0;
					i++;
					j++;
				}
				break;
			}
		}
		
		return result;
    }
}