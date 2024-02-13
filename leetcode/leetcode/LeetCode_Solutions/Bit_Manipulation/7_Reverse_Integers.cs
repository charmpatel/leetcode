/* 7 - Reverse Integers.
   Topic - Math.
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
Example 1:
Input: x = 123
Output: 321
Example 2:
Input: x = -123
Output: -321
Example 3:
Input: x = 120
Output: 21
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Bit_Manipulation
{
    public class _7_Reverse_Integers
    {
        public _7_Reverse_Integers()
        {
            int x = -123;
            Console.WriteLine("Reverse Int= {0}", reverseInt(x));
        }
        public int reverseInt(int x)
        {
            int res = 0, prev = 0;
            while (x != 0)
            {
                prev = res;
                res = res * 10 + (x % 10);
                x = x / 10;
                if (res / 10 != prev)
                {
                    res = 0;
                    break;
                }
            }
            return res;
        }
    }
}
