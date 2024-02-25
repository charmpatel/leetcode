﻿/* 704 - Binary Search
 * Topic - Array, Binary Search.
 Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
You must write an algorithm with O(log n) runtime complexity.
Example 1:
Input: nums = [-1, 0, 3, 5, 9, 12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4
Example 2:
Input: nums = [-1, 0, 3, 5, 9, 12], target = 2
Output: -1
Explanation: 2 does not exist in nums so return -1*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Binary_Search
{
    public class _704_Binary_Search
    {
        public _704_Binary_Search()
        {
            
        }
        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
