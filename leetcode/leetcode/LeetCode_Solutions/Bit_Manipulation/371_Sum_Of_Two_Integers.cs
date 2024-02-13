/* 371 - Sum Of Two Integers.
   Topic - Bit Manipulation, Math.
Given two integers a and b, return the sum of the two integers without using the operators +and -.
Example 1:
Input: a = 1, b = 2
Output: 3
Example 2:
Input: a = 2, b = 3
Output: 5
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Bit_Manipulation
{
    public class _371_Sum_Of_Two_Integers
    {
        public _371_Sum_Of_Two_Integers()
        {
            int a = 3;
            int b = 2;
            Console.WriteLine("Sum Of Two Int= {0}", sumOfTwoInt(a, b));
        }
        public int sumOfTwoInt(int a, int b)
        {
            if(b < 0)
            {
                for(int i = 0; i > b; i--)
                {
                    a--;
                }
            }
            else
            {
                for(int i = 1; i <= b; i++)
                {
                    a++;
                }
            }
            return a;
        }
    }
}
