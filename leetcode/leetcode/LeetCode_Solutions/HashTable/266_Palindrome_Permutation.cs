/* 266 -Palindrome Permutation
   Topic - Hash Table, Bit Manipulation, String.
Given a string s, return true if a permutation of the string could form a palindrome and false otherwise.
Example 1:
Input: s = "code"
Output: false
Example 2:
Input: s = "aab"
Output: true
Example 3:
Input: s = "carerac"
Output: true
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _266_Palindrome_Permutation
    {
        public _266_Palindrome_Permutation()
        {
            string s = "code";
            string s1 = "aab";
            string s2 = "carerac";
            Console.WriteLine(palindromePermutation(s)); //false
            Console.WriteLine(palindromePermutation(s1)); //true
            Console.WriteLine(palindromePermutation(s2)); //true
        }
        

        public bool palindromePermutation(string s)
        {
            HashSet<char> hs = new HashSet<char>();
            foreach(char ch in s)
            {
                if (hs.Contains(ch))
                {
                    hs.Remove(ch);
                }
                else
                {
                    hs.Add(ch);
                }
            }
            return hs.Count <= 1;
        }
    }
}
