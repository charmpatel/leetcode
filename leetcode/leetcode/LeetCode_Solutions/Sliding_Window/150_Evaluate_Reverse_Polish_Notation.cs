/* 150 - Evaluate Reverse Polish Notation
 * Topic - Array, Math, Stack.
 * You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.
Evaluate the expression. Return an integer that represents the value of the expression.
Note that:
The valid operators are '+', '-', '*', and '/'.
Each operand may be an integer or another expression.
The division between two integers always truncates toward zero.
There will not be any division by zero.
The input represents a valid arithmetic expression in a reverse polish notation.
The answer and all the intermediate calculations can be represented in a 32-bit integer.
Example 1:

Input: tokens = ["2", "1", "+", "3", "*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4", "13", "5", "/", "+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: tokens = ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]
Output: 22
Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
= ((10 * (6 / (12 * -11))) + 17) + 5
= ((10 * (6 / -132)) + 17) + 5
= ((10 * 0) + 17) + 5
= (0 + 17) + 5
= 17 + 5
= 22*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Sliding_Window
{
    public class _150_Evaluate_Reverse_Polish_Notation
    {
        public _150_Evaluate_Reverse_Polish_Notation()
        {
            string[] tokens = new string[] { "2", "1", "+", "3", "*" };
            string[] token1 = new string[] { "4", "13", "5", "/", "+" };
            string[] token2 = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            Console.WriteLine(evalRPN(tokens));
            Console.WriteLine(evalRPN(token1));
            Console.WriteLine(evalRPN(token2));
        }
        public int evalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            HashSet<string> hs = new HashSet<string>(new[] { "+", "-", "*", "/" });

            foreach(string item in tokens)
            {
                if (!hs.Contains(item))
                {
                    stack.Push(int.Parse(item));
                }
                else
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();

                    if(item == "+")
                    {
                        stack.Push(num1 + num2);
                    }
                    else if( item == "-")
                    {
                        stack.Push(num1 - num2);
                    }
                    else if(item == "*")
                    {
                        stack.Push(num1 * num2);
                    }
                    else
                    {
                        stack.Push(num1 / num2);
                    }
                }
            }
            return stack.Pop();
        }
    }
}
