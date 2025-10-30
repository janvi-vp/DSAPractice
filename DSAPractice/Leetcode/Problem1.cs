using System;
using System.Collections.Generic;
using System.Linq;

namespace DSAPractice.Leetcode
{
    public class Problem1
    {
        public int MinimumOperationsToWriteY(int[][] grid)
        {
            int n = grid.Length;
            int center = n / 2;

            HashSet<(int, int)> yPositions = new HashSet<(int, int)>();

            // Top-left to center diagonal
            for (int i = 0; i <= center; i++)
                yPositions.Add((i, i));

            // Top-right to center diagonal
            for (int i = 0; i <= center; i++)
                yPositions.Add((i, n - 1 - i));

            // Vertical line from center to bottom
            for (int i = center; i < n; i++)
                yPositions.Add((i, center));

            // Frequency counters
            int[] yCount = new int[3];
            int[] nonYCount = new int[3];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int val = grid[i][j];
                    if (yPositions.Contains((i, j)))
                        yCount[val]++;
                    else
                        nonYCount[val]++;
                }
            }

            int totalY = yCount.Sum();
            int totalNonY = nonYCount.Sum();

            int minOps = int.MaxValue;

            // Try all combinations (a for Y, b for non-Y)
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    if (a == b) continue;

                    int opsY = totalY - yCount[a];
                    int opsNonY = totalNonY - nonYCount[b];

                    minOps = Math.Min(minOps, opsY + opsNonY);
                }
            }

            return minOps;
        }
    }
}
