// 25. Maximal Value of Gifts

// Question: A board has n*m cells, and there is a gift with some value (value is greater than 0) in every cell. 
// You can get gifts starting from the top-left cell, and move right or down in each step, and finally reach the 
// cell at the bottom-right cell. What’s the maximal value of gifts you can get from the board?

public static int getMaxGift(int[][] values)
{
	int rows = values.Length;
	int cols = values[0].Length;
	
	int[] maxGifts = new int[rows][cols];
	
	for(int i = 0; i < rows; i++ )
	{
		for(int j = 0; j < cols; j++)
		{
			int left = 0;
			int up = 0;
			
			if(j > 0)
			{
				left = maxGifts[i][j-1];
			}
			
			if(i > 0)
			{
				up = maxGifts[i-1][j];
			}
			
			maxGifts[i][j] = Math.Max(left, up) + values[i][j];
		}
	}
	
	return maxGifs[rows-1][cols-1];
}