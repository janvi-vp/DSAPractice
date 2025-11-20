using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.Leetcode
{
    public class Problem8
    {
        public char[][] RotateTheBox(char[][] boxGrid) {
            int m = boxGrid.Length;
            int n = boxGrid[0].Length;

            char[][] rotated = new char[n][];
            for (int i = 0; i < n; i++)
            {
                rotated[i] = new char[m];
                for (int j = 0; j < m; j++)
                {
                    rotated[i][j] = boxGrid[m - 1 - j][i];
                }
            }

            for (int col = 0; col < m; col++)
            {
                int emptyPos = n - 1;

                for (int row = n - 1; row >= 0; row--)
                {
                    if (rotated[row][col] == '#')
                    {
                        rotated[row][col] = '.';
                        rotated[emptyPos][col] = '#';
                        emptyPos--;
                    }
                    else if (rotated[row][col] == '*')
                    {
                        emptyPos = row - 1;
                    }
                }
            }

            return rotated;
        }
    }
}