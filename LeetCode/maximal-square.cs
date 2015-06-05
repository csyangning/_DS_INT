// https://leetcode.com/problems/maximal-square/
// 
// Given a 2D binary matrix filled with 0's and 1's, find the largest square containing all 1's and return its area.
// 
// For example, given the following matrix:
// 
// 1 0 1 0 0
// 1 0 1 1 1
// 1 1 1 1 1
// 1 0 0 1 0
// Return 4.

//DP
public class Solution {
    public int MaximalSquare(char[,] matrix) {
		if(matrix == null)
		{
			return 0;
		}
		
		int[,] size = new int[matrix.GetLength(0), matrix.GetLength(1)];
		int maxSize = 0;
		
		for(int i = 0; i < matrix.GetLength(0); i++)
		{
			size[i, 0] = matrix[i, 0] - '0';
			maxSize = Math.Max(maxSize, size[i,0]);
		}
		
		for(int j = 0; j < matrix.GetLength(1); j++)
		{
			size[0,j] = matrix[0,j] - '0';
			maxSize = Math.Max(maxSize, size[0,j]);
		}
		
		for(int row = 1; row < matrix.GetLength(0); row++)
		{
			for(int col = 1; col < matrix.GetLength(1); col++)
			{
				if(matrix[row,col] == '1')
				{
					size[row,col] = Math.Min(size[row -1, col], Math.Min(size[row - 1, col -1], size[row, col - 1])) + 1;
					maxSize = Math.Max(maxSize, size[row,col]);
				}
			}
		}
	
		return maxSize * maxSize;
	}
}



// bru-force
public class Solution {
    public int MaximalSquare(char[,] matrix) {
        
		if(matrix == null)
		{
			return 0;
		}
		
		int maxSquare = 0;
		
		for(int i = 0; i < matrix.GetLength(0); i++)
		{
			for(int j = 0; j < matrix.GetLength(1); j++)
			{
				if(matrix[i,j] == '1')
				{
					int squareCount = FindMaxSquare(matrix, i, j);
					if(squareCount > maxSquare)
					{
						maxSquare = squareCount;
					}
				}
			}
		}
		
		return maxSquare;
    }
	
	private int FindMaxSquare(char[,] matrix, int row, int col)
	{
		int count = 1;
		bool squareFound = true;
		
		while(squareFound)
		{
			count++;
			
			if(row + count > matrix.GetLength(0) || col + count > matrix.GetLength(1))
			{
				break;
			}
						
			for(int i = row; i < row + count; i++)
			{
				if(!squareFound)
				{
					break;
				}
				
				for(int j = col; j < col + count; j++)
				{
					if(matrix[i,j] == '0')
					{
						squareFound = false;
						break;
					}
				}
			}
		}
		
		count--;
		
		for(int i = row; i < row + count; i++)
		{
			for(int j = col; j < col + count; j++)
			{
				matrix[i,j] = '0';
			}
		}
		
		return count * count;
	}
}