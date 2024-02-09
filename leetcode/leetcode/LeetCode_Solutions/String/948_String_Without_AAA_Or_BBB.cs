/* 948 - String Without AAA Or BBB.
   Topic - String, Greedy.
Given two integers a and b, return any string s such that:
s has length a + b and contains exactly a 'a' letters, and exactly b 'b' letters,
The substring 'aaa' does not occur in s, and
The substring 'bbb' does not occur in s.
Example 1:
Input: a = 1, b = 2
Output: "abb"
Explanation: "abb", "bab" and "bba" are all correct answers.
Example 2:
Input: a = 4, b = 1
Output: "aabaa"
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.String
{
    public class _948_String_Without_AAA_Or_BBB
    {
        public _948_String_Without_AAA_Or_BBB()
        {
            int a = 5;
            int b = 3;
            Console.WriteLine("String Without AAA Or BBB= {0}", stringWithout3A3B(a, b));
        }
        public string stringWithout3A3B(int a, int b)
        {
            string res = "";
            int curA = 0;
            int curB = 0;
            while(a > 0 || b > 0)
            {
                if((a>b && curA < 2) ||(a > 0 && curB == 2))
                {
                    res += 'a';
                    curA++;
                    curB = 0;
                    a--;
                }
                else
                {
                    res += 'b';
                    curB++;
                    curA = 0;
                    b--;
                }
            }
            return res;
        }
    }
}
