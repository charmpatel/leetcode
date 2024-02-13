/* 136 - Single Number
   Topic - Bit Manipulation, Array.
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
You must implement a solution with a linear runtime complexity and use only constant extra space.
Example 1:
Input: nums = [2, 2, 1]
Output: 1
Example 2:
Input: nums = [4, 1, 2, 1, 2]
Output: 4
Example 3:
Input: nums = [1]
Output: 1
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Bit_Manipulation
{
    public class _136_Single_Number
    {
        public _136_Single_Number()
        {
            int[] nums = new int[] { 4, 1, 2, 1, 2 };
            int[] num1 = new int[] { 2, 2, 1 };
            Console.WriteLine("Single Number= {0}", singleNum(nums));
            Console.WriteLine("Single Number= {0}", singleNum(num1));
        }
        public int singleNum(int[] nums)
        {
            int res = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                res = res ^ nums[i];
            }
            return res;
        }
    }
}
