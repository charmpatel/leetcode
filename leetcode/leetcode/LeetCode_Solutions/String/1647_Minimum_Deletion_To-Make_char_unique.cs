/* 1647 - Minimum Deletion To Make Char Frequencies Unique.
   Topic - String, Hash Table, Sorting, Greedy.
A string s is called good if there are no two different characters in s that have the same frequency.
Given a string s, return the minimum number of characters you need to delete to make s good.
The frequency of a character in a string is the number of times it appears in the string. For example, in the string "aab", the frequency of 'a' is 2, while the frequency of 'b' is 1.
Example 1:
Input: s = "aab"
Output: 0
Explanation: s is already good.
Example 2:
Input: s = "aaabbbcc"
Output: 2
Explanation: You can delete two 'b's resulting in the good string "aaabcc".
Another way it to delete one 'b' and one 'c' resulting in the good string "aaabbc".
Example 3:
Input: s = "ceabaacb"
Output: 2
Explanation: You can delete both 'c's resulting in the good string "eabaab".
Note that we only care about characters that are still in the string at the end (i.e. frequency of 0 is ignored).
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.String
{
    public class _1647_Minimum_Deletion_To_Make_char_unique
    {
        public _1647_Minimum_Deletion_To_Make_char_unique()
        {
            string s = "ceabaacb";
            Console.WriteLine("Minimum Deletion To Make Char Frequencies Unique= {0}", MinDeletions(s));
        }
        public int MinDeletions(string s)
        {
            int[] chars = new int[26];

            foreach (char c in s)
            {
                chars[c - 'a']++;
            }

            HashSet<int> hs = new HashSet<int>();
            int count = 0;

            foreach (int i in chars)
            {
                int freq = i;
                while (freq > 0 && !hs.Add(freq))
                {
                    freq--;
                    count++;
                }
            }
            return count;
        }
    }
}
