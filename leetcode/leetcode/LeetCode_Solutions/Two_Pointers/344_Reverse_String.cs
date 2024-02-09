/* 344 -Reverse String.
   Topic - String, Two Pointer.
Write a function that reverses a string. The input string is given as an array of characters s.
You must do this by modifying the input array in-place with O(1) extra memory.
Example 1:
Input: s = ["h", "e", "l", "l", "o"]
Output: ["o","l","l","e","h"]
Example 2:
Input: s = ["H", "a", "n", "n", "a", "h"]
Output: ["h","a","n","n","a","H"]
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.String
{
    public class _344_Reverse_String
    {
        public _344_Reverse_String()
        {
            char[] s = new char[] {'h','e','l','l','o' };
            ReverseString(s);
        }
        public void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }
            Console.Write("Revers String = ");
            foreach(char ch in s)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine("");
        }
    }
}
