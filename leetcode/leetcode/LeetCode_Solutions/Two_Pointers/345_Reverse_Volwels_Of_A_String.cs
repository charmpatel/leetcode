/* 345 - Reverse Volwels Of A String.
   Topic - Two Pointers, String.
Given a string s, reverse only all the vowels in the string and return it.
The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
Example 1:
Input: s = "hello"
Output: "holle"
Example 2:
Input: s = "leetcode"
Output: "leotcede"
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _345_Reverse_Volwels_Of_A_String
    {
        public _345_Reverse_Volwels_Of_A_String()
        {
            string s = "hello";
            string s1 = "LEETCODE";
            Console.WriteLine("Reverse Volwels= {0}", reverseVolwels(s));
            Console.WriteLine("Reverse Volwels= {0}", reverseVolwels(s1));
        }
        public string reverseVolwels(string s)
        {
            char[] charArr = s.ToCharArray();
            HashSet<char> hs = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int left = 0;
            int right = charArr.Length - 1;
            while(left < right)
            {
                while(left < right && !hs.Contains(charArr[left]))
                {
                    left++;
                }
                while(left < right && !hs.Contains(charArr[right]))
                {
                    right--;
                }
                char temp = charArr[left];
                charArr[left] = charArr[right];
                charArr[right] = temp;
                left++;
                right--;
            }
            return new string(charArr);
        }
    }
}
