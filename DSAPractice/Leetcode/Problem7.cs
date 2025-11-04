using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.Leetcode
{
    public class Problem7
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> res = new List<int[]>();
            var sorted = intervals.OrderBy(x => x[0]).ToArray();
            res.Add([sorted[0][0], sorted[0][1]]);
            for (int i = 1; i < intervals.Length; i++)
            {
                if (res[res.Count() - 1][0] <= sorted[i][0] && sorted[i][0] <= res[res.Count() - 1][1])
                {
                    res.Add([res[res.Count - 1][0], Math.Max(res[res.Count - 1][1], sorted[i][1])]);
                    res.RemoveAt(res.Count - 2);
                }
                else
                {
                    res.Add([sorted[i][0], sorted[i][1]]);
                }
            }

            return res.ToArray();
        }
    }
}