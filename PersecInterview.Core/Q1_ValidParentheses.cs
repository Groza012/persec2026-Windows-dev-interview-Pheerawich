using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersecInterview.Core
{
    public class Q1_ValidParentheses
    {

        public bool IsValid(string s)
        {
            Dictionary<char, char> MapParentheses = new Dictionary<char, char> {
            {')','('},
            {'}','{' },
            { ']','[' }
            };
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (MapParentheses.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Peek() != MapParentheses[c])
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
    }
}
