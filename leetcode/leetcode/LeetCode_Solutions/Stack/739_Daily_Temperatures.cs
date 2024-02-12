/* 739 - Daily Temperatures.
   Topic - Array, Stack, Monotonic Stack.
Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.
Example 1:
Input: temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
Output:[1,1,4,2,1,1,0,0]
Example 2:
Input: temperatures = [30, 40, 50, 60]
Output:[1,1,1,0]
Example 3:
Input: temperatures = [30, 60, 90]
Output:[1,1,0]
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Stack
{
    public class _739_Daily_Temperatures
    {
        public _739_Daily_Temperatures()
        {
            int[] temp = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            var res = dailyTemp(temp);
            Console.Write("Daily temp= ");
            foreach(var i in res)
            {
                Console.Write(", {0}",i);
            }
            Console.WriteLine();
        }
        public int[] dailyTemp(int[] temp)
        {
            int[] res = new int[temp.Length];
            Stack<int> stack = new Stack<int>();
            for(int i = temp.Length - 1; i >= 0; i--)
            {
                while(stack.Count > 0 && temp[i] >= temp[stack.Peek()])
                {
                    stack.Pop();
                }
                res[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
                stack.Push(i);
            }
            return res;
        }
    }
}
