/* 242 - Valid Anagram.
   Topic - String, Hash Table, Sorting.
Given two strings s and t, return true if t is an anagram of s, and false otherwise.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
Example 1:
Input: s = "anagram", t = "nagaram"
Output: true
Example 2:
Input: s = "rat", t = "car"
Output: false
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _242_Valid_Anagram
    {
        public _242_Valid_Anagram()
        {
            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine(isValidAnagram(s, t));
            string s1 = "rat";
            string t1 = "cat";
            Console.WriteLine(isValidAnagram(s1, t1));
        }
       /* Seudo Code-
        * check s of Length is not equal to t of Length then return false.
            create a dictionary of char and int.
            first loop through in String s.
            if dict contains current char then add val of it.
            otherwise add char = 1
            loop through in string t and check if current char not in dict then return false
            otherwise decrease the val of dict of char
            if char val == 0 then remove that char from dict
            at last check if dict.Count == 0 return true.*/

       public bool isValidAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char ch in s)
            {
                if(dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict[ch] = 1;
                }
            }
            foreach(char ch in t)
            {
                if (!dict.ContainsKey(ch))
                {
                    return false;
                }
                dict[ch]--;
                if(dict[ch] == 0)
                {
                    dict.Remove(ch);
                }
            }
            return dict.Count == 0;
        }
    }
}
