using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.Leetcode
{
    public class TestClass2
    {
        public List<int> Test(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new List<int>();

            var res = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int left = (i == 0) ? 0 : nums[i - 1];
                int right = (i == nums.Length - 1) ? 0 : nums[i + 1];

                res.Add(left + nums[i] + right);
            }

            return res;
        }
    }
}