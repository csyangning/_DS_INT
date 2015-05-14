//23. Group of 1s in a Matrix

// Problem: Given a matrix with 1s and 0s, please find the number of groups of 1s. A group is defined by horizontally or 
// vertically adjacent 1s. For example, there are four groups of 1s in Figure 1 which are drawn with different colors.

public class Solution {
    public int NumIslands(char[,] grid) {
        if(grid.Length == null)
        {
            return 0;
        }
        
        int row = grid.GetLength(0);
        int col = grid.GetLength(1);
        int count = 0;
        
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if(grid[i,j] == '1')
                {
                    FlipOnes(i,j,grid);
                    count++;
                }
            }
        }
        
        return count;
    }
    
    private void FlipOnes(int i, int j, char[,] grid)
    {
        int row = grid.GetLength(0);
        int col = grid.GetLength(1);

        
        Stack<int> indexStack = new Stack<int>();
        indexStack.Push(i*col + j);
        
        while(indexStack.Count != 0)
        {
            int index = indexStack.Pop();
            int nodeRow = index / col;
            int nodeCol = index % col;
            grid[nodeRow,nodeCol] = '0';

            
            if(nodeRow > 0 && grid[nodeRow - 1,nodeCol] == '1')
            {
                indexStack.Push((nodeRow - 1)* col + nodeCol);
            }
            if(nodeCol > 0 && grid[nodeRow,nodeCol - 1] == '1')
            {
                indexStack.Push(nodeRow * col + nodeCol - 1);
            }
            
            if(nodeCol < col -1 && grid[nodeRow,nodeCol+1] == '1')
            {
                indexStack.Push(nodeRow * col + nodeCol+1);
            }
            
            if(nodeRow < row - 1 && grid[nodeRow + 1,nodeCol] == '1')
            {
                indexStack.Push((nodeRow+1) * col + nodeCol);
            }
        }
        

        
    }
}