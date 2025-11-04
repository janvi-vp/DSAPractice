using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.Leetcode
{
    public class Problem5
    {
        public string SimplifyPath(string path) {

            string[] components = path.Split('/');
            Stack<string> stack = new Stack<string>();
            
            foreach (string component in components)
            {
                if (string.IsNullOrEmpty(component) || component == ".")
                {
                    continue;
                }
                else if (component == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(component);
                }
            }

            List<string> result = new List<string>(stack);
            result.Reverse();
            
            if (result.Count == 0)
            {
                return "/";
            }
            
            return "/" + string.Join("/", result);
        }
    }
}