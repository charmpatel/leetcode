/* 424 - Longest Repeating Character Replacement
   Topic - Hash Table, String, Sliding Window.
You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.
Return the length of the longest substring containing the same letter you can get after performing the above operations.
Example 1:
Input: s = "ABAB", k = 2
Output: 4
Explanation: Replace the two 'A's with two 'B's or vice versa.
Example 2:
Input: s = "AABABBA", k = 1
Output: 4
Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
The substring "BBBB" has the longest repeating letters, which is 4.
There may exists other ways to achieve this answer too.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.LeetCode_Solutions.Sliding_Window
{
    public class _424_Longest_Repeating_Character_Replacement
    {
        public _424_Longest_Repeating_Character_Replacement()
        {
            string s = "ABAB";
            int k = 2;
            string s1 = "AABABBA";
            int k1 = 2;
            Console.WriteLine("Longest Repeating Character Replacement= {0}", characterReplacement(s, k));
            Console.WriteLine("Longest Repeating Character Replacement= {0}", characterReplacement(s1, k1));
        }
        public int characterReplacement(string s, int k)
        {
           if(s.Length == 0)
            return 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int count = 0;
        int res = 0;
        int l = 0;
        //int

        for(int i = 0; i < s.Length; i++){
            if( !dict.ContainsKey(s[i])){
                dict.Add(s[i], 0);
            }
            dict[s[i]]++;
            count = Math.Max(count, dict[s[i]]);

            while((i-l+1) - count>k){
                dict[s[l++]]--;
            }
            res = Math.Max(res,i-l+1);
        } 
        return res;
        }
    }
}
