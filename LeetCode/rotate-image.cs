// https://leetcode.com/problems/rotate-image/

// You are given an n x n 2D matrix representing an image.
// 
// Rotate the image by 90 degrees (clockwise).

/*
 * clockwise rotate
 * first reverse up to down, then swap the symmetry 
 * 1 2 3     7 8 9     7 4 1
 * 4 5 6  => 4 5 6  => 8 5 2
 * 7 8 9     1 2 3     9 6 3
*/

/*
 * anticlockwise rotate
 * first reverse left to right, then swap the symmetry
 * 1 2 3     3 2 1     3 6 9
 * 4 5 6  => 6 5 4  => 2 5 8
 * 7 8 9     9 8 7     1 4 7
*/


  public class Solution
  {
      public void Rotate(int[,] matrix)
      {
          int row = matrix.GetLength(0);
          int col = matrix.GetLength(1);

          for (int i = 0; i < row / 2; i++)
          {
              for (int j = 0; j < col; j++)
              {
                  Switch(ref matrix[i,j], ref matrix[row - i - 1, j]);
              }
          }

          for (int i = 0; i < row; i++)
          {
              for (int j = i + 1; j < col; j++)
              {
                  Switch(ref matrix[i,j], ref matrix[j, i]);
              }
          }
      }

      private void Switch(ref int first, ref int second)
      {
          int tmp = first;
          first = second;
          second = tmp;
      }
  }