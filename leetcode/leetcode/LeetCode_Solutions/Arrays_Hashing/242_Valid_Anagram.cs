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
       /* Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        Example 1:

        Input: s = "anagram", t = "nagaram"
        Output: true
        Example 2:

        Input: s = "rat", t = "car"
        Output: false*/

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
