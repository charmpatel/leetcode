/* 70 - Climbing Stairs
   Topic - Math, Dynamic Programming, Memoization.
You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
Example 1:
Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:
Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Dynamic_Programming
{
    public class _70_Climbing_Stairs
    {
        public _70_Climbing_Stairs()
        {
            int n = 2;
            int n1 = 5;
            Console.WriteLine("Climbing Stairs - {0}", climbingStairs(n));
            Console.WriteLine("Climbing Stairs - {0}", climbingStairs(n1));
        }
        public int climbingStairs(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            int[] dp = new int[n];
            dp[0] = 1;
            dp[1] = 2;
            for(int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n - 1];
        }
    }
}
