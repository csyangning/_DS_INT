//  https://leetcode.com/problems/set-matrix-zeroes/
//  
//  Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in place.

public class Solution {
    public void SetZeroes(int[,] matrix) {
		bool firstCol = false;
		
		for(int i = 0; i < matrix.GetLength(0); i++)
		{
			if(matrix[i,0] == 0)
			{
				firstCol = true;
			}
			
			for(int j = 1; j < matrix.GetLength(1); j++)
			{
				
				if(matrix[i,j] == 0)
				{
					matrix[0, j] = 0;
					matrix[i, 0] = 0;
				}
			}
		}
		
        for(int i = matrix.GetLength(0) - 1; i >= 0; i--)
		{
			for(int j = matrix.GetLength(1) - 1; j > 0; j--)
			{
				if(matrix[0,j] == 0 || matrix[i,0] == 0)
				{
					matrix[i,j] = 0;
				} 
			}
			
			if(firstCol)
			{
				matrix[i,0] = 0;
			}
			
		}
    }
}