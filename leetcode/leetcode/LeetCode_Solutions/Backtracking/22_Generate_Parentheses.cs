/* 22 - Generate Parentheses.
   Topic - Stack, Backtracking, Dynamic Programming.
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
Example 1:
Input: n = 3
Output:["((()))","(()())","(())()","()(())","()()()"]
Example 2:
Input: n = 1
Output:["()"]
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Backtracking
{
    public class _22_Generate_Parentheses
    {
        public _22_Generate_Parentheses()
        {
            int n = 3;
            var res = generateParentheses(n);
            Console.Write("Generate Parentheses= ");
            foreach(var i in res)
            {
                Console.Write(",{0} ",i);
            }
        }
        public IList<string> generateParentheses(int n)
        {
            List<string> res = new List<string>();
            backtrack(n, 0, 0, res, "");
            return res;
        }
        private void backtrack(int n,int open, int close, IList<string> res, string curr)
        {
            if( open == n && close == n)
            {
                res.Add(curr);
                return;
            }
            if(open < n)
            {
                backtrack(n, open + 1, close, res, curr + "(");
            }
            if(close < open)
            {
                backtrack(n, open, close + 1, res, curr + ")");
            }
        }
    }
}
