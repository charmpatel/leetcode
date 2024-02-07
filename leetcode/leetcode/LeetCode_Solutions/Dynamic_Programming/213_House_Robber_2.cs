/* 213 - Hose Robber @.
   Topic - Array, Dynamic Programming.
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed. All houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, adjacent houses have a security system connected, and it will automatically contact the police if two adjacent houses were broken into on the same night.
Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.
Example 1:
Input: nums = [2, 3, 2]
Output: 3
Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent houses.
Example 2:
Input: nums = [1, 2, 3, 1]
Output: 4
Explanation: Rob house 1(money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.
Example 3:
Input: nums = [1, 2, 3]
Output: 3
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Dynamic_Programming
{
    public class _213_House_Robber_2
    {
        public _213_House_Robber_2()
        {
            int[] nums = new int[] { 2, 3, 2 };
            int[] num1 = new int[] { 1, 2, 3, 1 };
            Console.WriteLine("House Robber2 - {0}", houseRobber2(nums));
            Console.WriteLine("House Robber2 - {0}", houseRobber2(num1));
        }
        public int houseRobber2(int[] nums)
        {
            if(nums.Length == 1)
            {
                return nums[0];
            }
            if(nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            var sliceone = Helper(0, nums.Length - 1, nums);
            var slicetwo = Helper(1, nums.Length, nums);

            return Math.Max(sliceone, slicetwo);
        }
        private static int Helper(int l, int r ,int[] nums)
        {
            int first = nums[l];
            int two = Math.Max(nums[l], nums[l + 1]);
            for(int i = l + 2; i < r; i++)
            {
                int res = Math.Max(first + nums[i], two);
                first = two;
                two = res;
            }
            return two;
        }
    }
}
