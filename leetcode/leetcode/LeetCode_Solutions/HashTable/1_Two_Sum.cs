/* 1 - Two Sum.
Topic - Array, Hash Table.
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
Example 1:
Input: nums = [2, 7, 11, 15], target = 9
Output:[0,1]
Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
Example 2:
Input: nums = [3, 2, 4], target = 6
Output:[1,2]
Example 3:
Input: nums = [3, 3], target = 6
Output:[0,1]
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _1_Two_Sum
    {
        public _1_Two_Sum()
        {            
        }

       /* Seudo Code:
            first use Dictionary to track the value and it's index.
            create dict with both para int.
            loop through in nums array. and check target - currunt num  is equals to new int.
            check if new int in dict then return boths indexes.
            if not in Dictionary then add curr int in Dictionary.
            if you don't found num return [0].

            Create a dictionary to store the element and its index.
            Loop through all numbers... 
                check if there exists a key where key = target-element in dictionary, 
                    in that case, we have found two elemnts (the element itself and the one in dict where key = target-element
                    return dict[target-element] & i (which is index of current element)
                check if element is not in dict, add it 
            
*/

         public int[] twoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i <= nums.Length; i++)
            {
                int x = target - nums[i];
                if (dict.ContainsKey(x))
                {
                    return new int[] { dict[x], i };
                }
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
            }
           return new int[] { 0 };
        }

    }
}
