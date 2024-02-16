﻿/* 66 - Plus One.
   Topic -Array, Math.
You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
Increment the large integer by one and return the resulting array of digits.
Example 1:
Input: digits = [1, 2, 3]
Output:[1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
Example 2:
Input: digits = [4, 3, 2, 1]
Output:[4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].
Example 3:
Input: digits = [9]
Output:[1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _66_Plus_One
    {
        public _66_Plus_One()
        {
            int[] digit = new int[] { 4, 3, 2, 1 };
            int[] digit1 = new int[] { 9 };
            int[] res = plusOne(digit1);

            Console.Write("One Plus=");
            foreach (int i in res)
            {
                Console.Write( i);
            }
            Console.WriteLine("");
        }
        public int[] plusOne(int[] digits)
        {
            for(int i = digits.Length - 1; i >= 0; i--)
            {
                if(digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
