// https://leetcode.com/problems/sudoku-solver/
//
// Write a program to solve a Sudoku puzzle by filling the empty cells.
//
// Empty cells are indicated by the character '.'.
//
// You may assume that there will be only one unique solution.

public class Solution {
    public void SolveSudoku(char[,] board) {
        if(board == null || board.GetLength(0) == 0)
        {
            return;
        }

        Solve(board);
    }

    private bool Solve(char[,] board)
    {
        for(int i = 0; i < board.GetLength(0); i++)
        {
            for(int j = 0; j < board.GetLength(1); j++)
            {
                if(board[i,j] == '.')
                {
                    for(char c = '1'; c <='9'; c++)
                    {
                        if(IsValid(board, i, j, c))
                        {
                            board[i,j] = c;
                            if(Solve(board))
                            {
                                return true;
                            }

                            board[i,j] = '.';
                        }
                    }

                    return false;
                }
            }
        }

        return true;
    }

    private bool IsValid(char[,] board, int i, int j, char c)
    {
        for(int m = 0; m < 9; m++)
        {
            if(board[m, j] == c)
            {
                return false;
            }

            if(board[i, m] == c)
            {
                return false;
            }
        }

        int blockRow = (i / 3) * 3;
        int blockCol = (j / 3) * 3;
        for(int m = 0; m < 3; m++)
        {
            for(int n = 0; n < 3; n++)
            {
                if(board[blockRow + m, blockCol + n] == c)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
