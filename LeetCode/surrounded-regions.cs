// https://leetcode.com/problems/surrounded-regions/
//  
//  Given a 2D board containing 'X' and 'O', capture all regions surrounded by 'X'.
//  
//  A region is captured by flipping all 'O's into 'X's in that surrounded region.
//  
//  For example,
//  X X X X
//  X O O X
//  X X O X
//  X O X X
//  After running your function, the board should be:
//  
//  X X X X
//  X X X X
//  X X X X
//  X O X X


public class Solution {
    
    private void Convert(char[,] board, int row, int col)
    {
        int rowSize = board.GetLength(0);
        int colSize = board.GetLength(1);
        Stack<int> stack  = new Stack<int>();
        stack.Push(GetIndex(row, col, colSize));
        while (stack.Count != 0)
        {
            int index = stack.Pop();
            int r = index / colSize;
            int c = index % colSize;
            
            board[r,c] = 'Y';
            
            if(r + 1 < rowSize && board[r + 1, c] == 'O')
            {
                stack.Push(GetIndex(r + 1, c, colSize));   
            }
            
            if(r - 1 >= 0 && board[r - 1, c] == 'O')
            {
                stack.Push(GetIndex(r - 1, c, colSize));
            }
            
            if(c + 1 < colSize && board[r, c + 1] == 'O')
            {
                stack.Push(GetIndex(r, c + 1, colSize));
            }
            
            if(c - 1 >= 0 && board[r, c - 1] == 'O')
            {
                stack.Push(GetIndex(r, c - 1, colSize));
            }
        }
    }
    
    private int GetIndex(int r, int c, int colSize)
    {
        return r * colSize + c;
    }
    
    public void Solve(char[,] board) {
        if (board == null)
        {
            return;
        }
        
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if(i == 0 || i == board.GetLength(0) - 1 || j == 0 || j == board.GetLength(1) - 1)
                {
                    if(board[i,j] == 'O')
                    {
                        Convert(board, i, j);
                    }
                }
            }
        }
        
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i,j] == 'O')
                {
                    board[i,j] = 'X';
                }
                
                if (board[i,j] == 'Y')
                {
                    board[i,j] = 'O';
                }
            }
        }
    }
}