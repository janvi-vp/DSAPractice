using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Leetcode
{
    public class TestClass
    {
        static HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
        public int Test1(string source, string pattern)
        {

            int patternLength = pattern.Length;
            int sourceLength = source.Length;
            int count = 0;

            if (patternLength > sourceLength)
                return 0;

            for (int i = 0; i <= sourceLength - patternLength; i++)
            {
                bool match = true;
                for (int j = 0; j < patternLength; j++)
                {
                    char c = source[i + j];
                    bool isVowel = vowels.Contains(c);

                    if ((pattern[j] == '0' && !isVowel) || (pattern[j] == '1' && isVowel))
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                    count++;
            }

            return count;
        }
    }   
}
