//23. Group of 1s in a Matrix

// Problem: Given a matrix with 1s and 0s, please find the number of groups of 1s. A group is defined by horizontally or 
// vertically adjacent 1s. For example, there are four groups of 1s in Figure 1 which are drawn with different colors.

public static int GroupCounts (int[,] matrix, int rows, int columns)
{
	if(matrix == null || rows == 0 || columns == 0)
	{
		return 0;
	}
	
	int group = 0;
	
	for(int i = 0; i < rows; i ++)
	{
		for(int j = 0; j < columns; j++)
		{
			if(matrix[i,j] == 1)
			{
				group++;
				FlipGroup(matrix, i, j, rows, columns);
			}
		}
	}
	
	return group
}

public static void FlipGroup(int[,] matrix, int rowIndex, int columnIndex, int rows, int columns)
{
	Stack<int> indexStack = new Stack<int>();
	indexStack.Push(rowIndex*columns + columnIndex);
	
	while(indexStack.Length != 0)
	{
		int flipIndex = indexStack.Pop();
		int row = flipIndex /columns;
		int column = flipIndex % columns;
		
		matrix[row, column] == 0;
		
		if(row > 0 && matrix[row -1, column] == 1)
		{
			indexStack.Push((row-1)*columns + column);
		}
		
		// ... etc.push left, right, bottom to the stack.
	}
}