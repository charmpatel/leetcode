/* 153 Find Minimum In Rotated Sorted Array
 * Topic - Array, Binary Search
 Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:
[4,5,6,7,0,1,2] if it was rotated 4 times.
[0, 1, 2, 4, 5, 6, 7] if it was rotated 7 times.
Notice that rotating an array [a[0], a[1], a[2], ..., a[n - 1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n - 2]].
Given the sorted rotated array nums of unique elements, return the minimum element of this array.
You must write an algorithm that runs in O(log n) time.
Example 1:
Input: nums = [3, 4, 5, 1, 2]
Output: 1
Explanation: The original array was[1, 2, 3, 4, 5] rotated 3 times.
Example 2:
Input: nums = [4, 5, 6, 7, 0, 1, 2]
Output: 0
Explanation: The original array was[0, 1, 2, 4, 5, 6, 7] and it was rotated 4 times.
Example 3:
Input: nums = [11, 13, 15, 17]
Output: 11
Explanation: The original array was[11, 13, 15, 17] and it was rotated 4 times.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Binary_Search
{
    public class _153_Find_Minimum_In_Rotated_Sorted_Array
    {
        public _153_Find_Minimum_In_Rotated_Sorted_Array()
        {
            int[] nums = new int[] { 3, 4, 5, 1, 2 };
            int[] num1 = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            Console.WriteLine("min num in rotated sorted array {0} ", findMin(nums));
            Console.WriteLine("min num in rotated sorted array {0} ", findMin(num1));
        }


        public int findMin(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            var mid = 0;
            while (left <= right)
            {
                if (nums[left] <= nums[right])
                {
                    return nums[left];
                }

                mid = (left + right) / 2;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else if (nums[mid] < nums[right])
                {
                    right = mid;
                }
            }
            return -1;
        }
    }
}
