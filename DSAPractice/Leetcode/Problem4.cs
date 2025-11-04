using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace DSAPractice.Leetcode
{
    public class Problem4
    {
        public int CountMatchingSubarrays(int[] nums, int[] pattern)
        {

            int source = nums.Length;
            int pat = pattern.Length;
            int count = 0;

            for (int i = 0; i < source - pat; i++)
            {
                bool isValid = true;
                for (int j = 0; j < pat; j++)
                {
                    if (nums[i + j + 1] > nums[i + j] && pattern[j] == 1)
                    {
                        continue;
                    }
                    else if (nums[i + j + 1] < nums[i + j] && pattern[j] == -1)
                    {
                        continue;
                    }
                    else if (nums[i + j + 1] == nums[i + j] && pattern[j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                
                if(isValid == true)
                {
                    count++;
                }
            }

            return count;
        }
    }
}