/* 20 - Valid Parentheses
 * Topic - String, Stack.

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
Example 1:
Input: s = "()"
Output: true
Example 2:
Input: s = "()[]{}"
Output: true
Example 3:
Input: s = "(]"
Output: false
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.LeetCode_Solutions.Sliding_Window
{
    public class _20_Valid_Parentheses
    {
        public _20_Valid_Parentheses()
        {
            string s = "()";
            string s1 = "(){}[]";
            string s2 = "{]";
            Console.WriteLine(isValidParenth(s));
            Console.WriteLine(isValidParenth(s1));
            Console.WriteLine(isValidParenth(s2));
        }
        public bool isValidParenth(string s)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                { '{', '}' },
                { '[', ']' },
                { '(', ')' }
            };
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.Keys.Contains(s[i]))
                {
                    stack.Push(s[i]);
                }
                else if (stack.Count > 0 && s[i] == dict[stack.Peek()])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
