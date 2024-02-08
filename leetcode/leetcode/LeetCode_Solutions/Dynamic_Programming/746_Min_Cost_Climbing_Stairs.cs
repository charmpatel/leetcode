/* 746 - Min Cost Climbing Stairs.
   Topic - Array , Dynamic Programming.
You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.
You can either start from the step with index 0, or the step with index 1.
Return the minimum cost to reach the top of the floor.
Example 1:
Input: cost = [10, 15, 20]
Output: 15
Explanation: You will start at index 1.
- Pay 15 and climb two steps to reach the top.
The total cost is 15.
Example 2:
Input: cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1]
Output: 6
Explanation: You will start at index 0.
- Pay 1 and climb two steps to reach index 2.
- Pay 1 and climb two steps to reach index 4.
- Pay 1 and climb two steps to reach index 6.
- Pay 1 and climb one step to reach index 7.
- Pay 1 and climb two steps to reach index 9.
- Pay 1 and climb one step to reach the top.
The total cost is 6.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Dynamic_Programming
{
    public class _746_Min_Cost_Climbing_Stairs
    {
        public _746_Min_Cost_Climbing_Stairs()
        {
            int[] cost = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            int[] cost1 = new int[] { 10,15,20 };
            Console.WriteLine("Min Cost Climbing Stairs- {0}", minCostClimbingStairs(cost));
            Console.WriteLine("Min Cost Climbing Stairs- {0}", minCostClimbingStairs(cost1));
        }
        public int minCostClimbingStairs(int[] cost)
        {
            if(cost.Length == 2)
            {
                return Math.Min(cost[0], cost[1]);
            }
            int[] dp = new int[cost.Length];
            dp[0] = 0;
            dp[1] = Math.Min(cost[0], cost[1]);
            for (int i = 2; i < cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + cost[i], dp[i - 2] + cost[i - 1]);
            }
            return dp[cost.Length - 1];
        }
    }
}
