using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _49_Group_Anagram
    {
        public _49_Group_Anagram()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result1 = groupAnagram(strs);
            
            for (int n = 0; n < result1.Count; n++)
            {

                // Print the row number 
                Console.WriteLine("Row({0}): ", n);

                for (int k = 0; k < result1[n].Count; k++)
                {

                    // Print the elements in the row 
                    Console.WriteLine("{0} ", result1[n][k]);
                }
            }
            Console.WriteLine("");
        }
        /*Given an array of strings strs, group the anagrams together.You can return the answer in any order.
         * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        Example 1:
        Input: strs = ["eat","tea","tan","ate","nat","bat"]
            Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
        Example 2:
        Input: strs = [""]
            Output: [[""]]
        Example 3:
        Input: strs = ["a"]
            Output: [["a"]]*/

        public IList<IList<string>> groupAnagram(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            foreach(string str in strs)
            {
                var temp = str.ToCharArray();
                Array.Sort(temp);
                string res = new string(temp);
                if(!dict.ContainsKey(res))
                {
                    dict[res] = new List<string>();
                }
                dict[res].Add(str);
            }
            return new List<IList<string>>(dict.Values);
        }
    }
}
