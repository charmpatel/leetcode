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
