/* 1822 - Sign Of The Product Of The An Array
 * Topic - Array, Math.
 * 
 * There is a function signFunc(x) that returns:
1 if x is positive.
- 1 if x is negative.
 0 if x is equal to 0.
You are given an integer array nums. Let product be the product of all values in the array nums.Return signFunc(product).
Example 1:
Input: nums = [-1, -2, -3, -4, 3, 2, 1]
Output: 1
Explanation: The product of all values in the array is 144, and signFunc(144) = 1
Example 2:
Input: nums = [1, 5, 0, 2, -3]
Output: 0
Explanation: The product of all values in the array is 0, and signFunc(0) = 0
Example 3:
Input: nums = [-1, 1, -1, 1, -1]
Output: -1
Explanation: The product of all values in the array is -1, and signFunc(-1) = -1
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _1822_Sign_Of_the_Product_Of_An_Array
    {
        public _1822_Sign_Of_the_Product_Of_An_Array()
        {
            int[] nums = new int[] { -1, -2, -3, -4, 3, 2, 1 };
            int[] num1 = new int[] { 1, 5, 0, 2, -3 };
            int[] num2 = new int[] { -1, 1, -1, 1, -1};
            Console.WriteLine("Sign of Product {0}",signOfProduct(nums));
            Console.WriteLine("Sign of Product {0}", signOfProduct(num1));
            Console.WriteLine("Sign of Product {0}", signOfProduct(num2));
        }
        /*Seudo code-
            if any num 0 in nums then return 0
            loop through in nums and count negative nums.
            if count % 2 == 0 then return 1 etle -1.*/

        public int signOfProduct(int[] nums)
        {
            int count = 0;
            if(nums.Length == 0)
            {
                return 0;
            }
            foreach(int num in nums){
                if(num == 0)
                {
                    return 0;
                }
                if( num < 0)
                {
                    count++;
                }
            }
            return (count%2 == 0) ? 1:-1;
        }
    }
}
