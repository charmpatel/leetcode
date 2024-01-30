/****
 * Question# 1 : Two Sum
 * 
 * 
 * 
 * 
 *///
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _1_Two_Sum
    {
        public _1_Two_Sum()
        {
            int target = 9;
            int[] nums = new int[] { 11,12,14,15,16,18,100,2, 7 };
            int[] res = twoSum(nums, target);
            for(int i = 0; i<res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            
        }
       
        public int[] twoSum(int[] nums ,int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();


            for (int i = 0; i <= nums.Length; i++)
            {

                int x = target - nums[i]; // x = 9 -2 = 2

                if (dict.ContainsKey(x))
                {
                    return new int[] { dict[x], i };
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i; // dict <2,0>
                }
            }
            return new int[0];
        }
    }
}
