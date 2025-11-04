using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.Leetcode
{
    public class Problem3
    {
        public long[] CountBlackBlocks(int m, int n, int[][] coordinates) {
            long[] res = new long[5];
            Dictionary<(int, int), long> dict = new();
            for (int i = 0; i < coordinates.Length; i++)
            {
                var item = coordinates[i];
                if (item[0] >= 0 && item[0] < m-1 && item[1] >= 0 && item[1] < n-1)
                {
                    if (dict.ContainsKey((item[0], item[1])))
                    {
                        dict[(item[0], item[1])]+=(long)1;                       
                    }
                    else
                    {
                        dict.Add((item[0], item[1]), 1);
                    }
                }
                if (item[0]-1 >= 0 && item[1] - 1 >= 0) 
                {
                    if (dict.ContainsKey((item[0] - 1, item[1] - 1)))
                    {
                        dict[(item[0] - 1, item[1] - 1)]+=(long)1;                       
                    }
                    else
                    {
                        dict.Add((item[0] - 1, item[1] - 1), 1);
                    }
                }
                if (item[0] - 1 >= 0 && item[1] >=0 && item[1] < n-1)
                {
                    if (dict.ContainsKey((item[0] - 1, item[1])))
                    {
                        dict[(item[0] - 1, item[1])]+=(long)1;                       
                    }
                    else
                    {
                        dict.Add((item[0] - 1, item[1]), 1);
                    }
                }
                if (item[1] - 1 >= 0 && item[0] >=0 && item[0] < m-1)
                {
                    if (dict.ContainsKey((item[0], item[1] - 1)))
                    {
                        dict[(item[0], item[1] - 1)]+=(long)1;                       
                    }
                    else
                    {
                        dict.Add((item[0], item[1] - 1), 1);
                    }
                }
            }

            foreach (var kvp in dict)
            {
                res[kvp.Value]++;
            }
            res[0] = ((m - (long)1) * (n - (long)1)) - (res[1] + res[2] + res[3] + res[4]);
            return res;
        }
    }
}