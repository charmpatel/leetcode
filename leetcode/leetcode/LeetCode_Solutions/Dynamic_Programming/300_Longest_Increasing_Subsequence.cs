/* 300 - Longest Increasing Subsequence
   Topic - Array, Binary search, Dynamic Programming.
Given an integer array nums, return the length of the longest strictly increasing 
subsequence
Example 1:
Input: nums = [10, 9, 2, 5, 3, 7, 101, 18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.
Example 2:
Input: nums = [0, 1, 0, 3, 2, 3]
Output: 4
Example 3:
Input: nums = [7, 7, 7, 7, 7, 7, 7]
Output: 1
*/ 

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Dynamic_Programming
{
    public class _300_Longest_Increasing_Subsequence
    {
        public _300_Longest_Increasing_Subsequence()
        {
            int[] nums = new int[] { 10, 9, 2, 5, 3, 7, 101, 18 };
            int[] num1 = new int[] { 0, 1, 0, 3, 2, 3 , 4, 10, 1 };
            Console.WriteLine("Longest Increasing Subsequence= {0}", lengthOfSubSequence(nums));
            Console.WriteLine("Longest Increasing Subsequence= {0}", lengthOfSubSequence(num1));
        }
        public int lengthOfSubSequence(int[] nums)
        {
            int[] dp = new int[nums.Length];
            Array.Fill(dp, 1);
            var res = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                        res = Math.Max(res, dp[i]);
                    }
                }
            }
            return res;
        }
    }
}
