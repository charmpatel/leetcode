/* 322 - Coin Change.
   Topic - Array, Dynamic Programming, Bfs.
You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.
Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.
You may assume that you have an infinite number of each kind of coin.
Example 1:
Input: coins = [1, 2, 5], amount = 11
Output: 3
Explanation: 11 = 5 + 5 + 1
Example 2:
Input: coins = [2], amount = 3
Output: -1
Example 3:
Input: coins = [1], amount = 0
Output: 0
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Dynamic_Programming
{
    public class _322_Coin_Change
    {
        public _322_Coin_Change()
        {
            int[] coins = new int[] { 1, 2, 5 };
            int amount = 11;
            Console.WriteLine("Coin Change= {0}", coinChange(coins, amount));
        }
        public int coinChange(int[] coins, int amount)
        {
            //Build DP array
            int[] dp = new int[amount + 1];
            //Fill array with Amount + 1
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = amount + 1;
            }
            //Base case
            dp[0] = 0;

            //Outer loop is for coins
            foreach (int coin in coins)
            {
                //Iterate over DP array to find how many coins needed to form that total of amount
                //Start from the denomination of coin as it's not possible to make total less than the denomination with this coin
                for (int i = coin; i <= amount; i++)
                {
                    //Update the DP array with minimum number of coins needed to make the total
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
            //Catch condition where if its not possible to form total with given coins return -1
            return dp[amount] <= amount ? dp[amount] : -1;
        }
    }
}
