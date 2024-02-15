/* 202 - Happy Number
   Topic - Hash Table, Two Pointers, Math.
Write an algorithm to determine if a number n is happy.
A happy number is a number defined by the following process:
Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.
Example 1:
Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
Example 2:
Input: n = 2
Output: false
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _202_Happy_Number
    {
        public _202_Happy_Number()
        {
            int n = 13;
            int n1 = 25;
            int n2 = 77;
            int n3 = 7;
            Console.WriteLine("Happy Number= {0} ", isHappyNum(n));
            Console.WriteLine("Happy Number= {0} ", isHappyNum(n1));
            Console.WriteLine("Happy Number= {0} ", isHappyNum(n2));
            Console.WriteLine("Happy Number= {0} ", isHappyNum(n3));
        }
        public bool isHappyNum(int n)
        {
            if( n == 1 || n == 7)
            {
                return true;
            }
            if(n < 10)
            {
                return false;
            }
            var sum = 0;
            while( n > 0)
            {
                var r = n % 10;
                n = n/10;
                sum += r * r;
            }
            return sum == 1 || isHappyNum(sum);
        }
    }
}
