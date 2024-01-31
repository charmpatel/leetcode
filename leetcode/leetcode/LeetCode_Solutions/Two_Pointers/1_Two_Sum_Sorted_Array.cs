/*1- Two Sum Sorted Array
 * Topic - Array, Math, Two pointers
 * Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.
Note:
Your returned answers (both index1 and index2) are not zero-based.
You may assume that each input would have _exactly _one solution and you may not use the _same _element twice.
Input: numbers = [2, 7, 11, 15], target = 9
Output:[1,2]
Explanation: The sum of 2 and 7 is 9.Therefore index1 = 1, index2 = 2.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _1_Two_Sum_Sorted_Array
    {
        public _1_Two_Sum_Sorted_Array()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            var res = twoSumSortedArray(nums, target);
            Console.Write("Two Sum Sorted Array ");
            foreach (int i in res)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
        }
        public int[] twoSumSortedArray(int[] nums,int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while(left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if(sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return new int[] { };
            
        }
    }
}
