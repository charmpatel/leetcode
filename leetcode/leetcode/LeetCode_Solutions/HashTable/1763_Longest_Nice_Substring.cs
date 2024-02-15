/* 1763 -Longest Nice Substring
   Topic - Hash Table, String, Sliding Window, Bit Manipulation, Divide and Conqure. 
A string s is nice if, for every letter of the alphabet that s contains, it appears both in uppercase and lowercase. For example, "abABB" is nice because 'A' and 'a' appear, and 'B' and 'b' appear. However, "abA" is not because 'b' appears, but 'B' does not.
Given a string s, return the longest substring of s that is nice. If there are multiple, return the substring of the earliest occurrence. If there are none, return an empty string.
Example 1:
Input: s = "YazaAay"
Output: "aAa"
Explanation: "aAa" is a nice string because 'A/a' is the only letter of the alphabet in s, and both 'A' and 'a' appear.
"aAa" is the longest nice substring.
Example 2:
Input: s = "Bb"
Output: "Bb"
Explanation: "Bb" is a nice string because both 'B' and 'b' appear. The whole string is a substring.
Example 3:
Input: s = "c"
Output: ""
Explanation: There are no nice substrings.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _1763_Longest_Nice_Substring
    {
        public _1763_Longest_Nice_Substring()
        {
            string s = "YazAaVvIiPpAaTtEeLly";
            string s1 = "jfnWJFNdnvmAVIPATELavipatelngdjhnbgj";
            Console.WriteLine(longestNiceSubstring(s));
            Console.WriteLine(longestNiceSubstring(s1));
        }
        public string longestNiceSubstring(string s)
        {
            if(s.Length == 1)
            {
                return "";
            }
            HashSet<char> hs = new HashSet<char>(s);
            for(int i = 0; i < s.Length; i++)
            {
                if(hs.Contains(char.ToUpper(s[i])) && hs.Contains(char.ToLower(s[i])))
                {
                    continue;
                }
                string left = longestNiceSubstring(s.Substring(0, i));
                string right = longestNiceSubstring(s.Substring(i + 1, s.Length - i - 1));
                return left.Length >= right.Length ? left : right;
            }
            return s;
        }
    }
}
