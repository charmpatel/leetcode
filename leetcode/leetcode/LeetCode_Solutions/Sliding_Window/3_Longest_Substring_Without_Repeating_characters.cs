/*
 * 3 - Longest Substring Without Repeating Characters.
 * Given a string s, find the length of the longest substring without repeating characters.
Example 1:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

 Topic - HashTable, String , Sliding Window.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Sliding_Window
{
    public class _3_Longest_Substring_Without_Repeating_characters
    {
        public _3_Longest_Substring_Without_Repeating_characters()
        {
            string s = "abccba";
            string s1 = "bbbbb";
            Console.WriteLine("longest Substring without repeating char {0}", longestSubstring(s));
            Console.WriteLine("longest Substring without repeating char {0}", longestSubstring(s1));
        }
        public int longestSubstring(string s)
        {
            int start = 0;
            int end = 0;
            int count = 0;
            HashSet<int> hs = new HashSet<int>();

            while(end < s.Length)
            {
                if(!hs.Contains(s[end]))
                {
                    hs.Add(s[end]);
                    end++;
                    count = Math.Max(count, hs.Count);
                }
                else
                {
                    hs.Remove(s[start]);
                    start++;
                }
            }
            return count;
        }
    }
}
