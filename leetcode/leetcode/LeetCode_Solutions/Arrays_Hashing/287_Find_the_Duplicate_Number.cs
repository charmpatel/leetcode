/* 287 - Find The Duplicate Number
   Topic - Array, Binary Search, Two Pointer,Bit Manipulation
Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.
There is only one repeated number in nums, return this repeated number.
You must solve the problem without modifying the array nums and uses only constant extra space.
Example 1:
Input: nums = [1, 3, 4, 2, 2]
Output: 2
Example 2:
Input: nums = [3, 1, 3, 4, 2]
Output: 3
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _287_Find_the_Duplicate_Number
    {
        public _287_Find_the_Duplicate_Number()
        {
            int[] nums = new int[] { 3,11 ,2 , 0, 1 ,3};
            int[] num1 = new int[] {  6, 4, 2, 3, 5, 7, 0, 1,9, 9 };
            int[] num2 = new int[] { 100, 120, 150, 150 };

            Console.WriteLine(findDuplicate(nums));
            Console.WriteLine(findDuplicate(num1));
            Console.WriteLine(findDuplicate(num2));

        }
        public int findDuplicate(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            foreach(int num in nums)
            {
                if (hs.Contains(num))
                {
                    return num;
                }
                hs.Add(num);
            }
            return -1;
        }
    }
}
