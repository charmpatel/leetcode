/* 217 - Contains Duplicate
   Topic - Array, Hash Table, Sorting.
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
Example 1:
Input: nums = [1, 2, 3, 1]
Output: true
Example 2:
Input: nums = [1, 2, 3, 4]
Output: false
Example 3:
Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
Output: true
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _217_Contains_Duplicate
    {
        public _217_Contains_Duplicate()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            int[] num1 = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Contains Duplicate {0} ", containsDuplicate(nums));
            Console.WriteLine("Contains Duplicate {0} ", containsDuplicate(num1));
        }
        /*Seudo Code-
            create a HashSet of int type.
            loop through in nums and check if num in HashSet then return true.
            if num not in HashSet then add num in HashSet.
            if loop done then return false.*/
        public bool containsDuplicate(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            foreach(int num in nums)
            {
                if (hs.Contains(num))
                {
                    return true;
                }
                else
                {
                    hs.Add(num);
                }
            }
            return false;
        }
    }
}
