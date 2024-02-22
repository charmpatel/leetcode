/* 680 - Valid Planidrome 2.
Topic - Two Pointers, String , Greedy.
Given a string s, return true if the s can be palindrome after deleting at most one character from it.
Example 1:
Input: s = "aba"
Output: true
Example 2:
Input: s = "abca"
Output: true
Explanation: You could delete the character 'c'.
Example 3:
Input: s = "abc"
Output: false
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _680_Valid_Palindrome_2
    {
        public _680_Valid_Palindrome_2()
        {
            string s = "abba";
            string s1 = "abca";
            string s2 = "abcdef";
            Console.WriteLine("Valid Planidrome 2 {0}", validPalindrome2(s));
            Console.WriteLine("Valid Planidrome 2 {0}", validPalindrome2(s1));
            Console.WriteLine("Valid Planidrome 2 {0}", validPalindrome2(s2));
        }
        
        public bool validPalindrome2(string s)
         {
             int left = 0;
             int right = s.Length - 1;
             while (left < right)
             {
                 if(s[left] == s[right])
                 {
                     left++;
                     right--;
                 }
                 else
                 {
                     return isPalindrome(s, left + 1, right) || isPalindrome(s, left, right - 1);
                 }
             }
             return true;
         }
         public bool isPalindrome(string s, int left, int right)
         {
             while (left < right)
             {
                 if(s[left] != s[right])
                 {
                     return false;
                 }
                 left++;
                 right--;
             }
             return true;
         }
    }
}
