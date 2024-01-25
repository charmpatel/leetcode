using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _125_Valid_Palindrome
    {
        public _125_Valid_Palindrome()
        {
            string s = "A man, a plan, a canal: Panama";
            string s1 = "race a car";
            string s2 = " ";

            Console.WriteLine(isPalindrome(s));
            Console.WriteLine(isPalindrome(s1));
            Console.WriteLine(isPalindrome(s2));
        }
        public bool isPalindrome(string s)
        {
            for(int i = 0, j = s.Length - 1; j > 1;)
            {
                if(!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                if(!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }
                if( char.ToLower(s[i++]) != (char.ToLower(s[j--])))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
