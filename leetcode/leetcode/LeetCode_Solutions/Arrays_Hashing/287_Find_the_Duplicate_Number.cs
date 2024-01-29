using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _287_Find_the_Duplicate_Number
    {
        public _287_Find_the_Duplicate_Number()
        {
            int[] nums = new int[] { 3,11 ,2 , 0, 1 ,3};
            int[] num1 = new int[] {  6, 4, 2, 3, 5, 7, 0, 1,9, 9 };
            int[] num2 = new int[] { 100, 120, 150, 150 };

            Console.WriteLine(findDuplicate(nums));
            Console.WriteLine(findDuplicate(num1));
            Console.WriteLine(findDuplicate(num2));

        }
        public int findDuplicate(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            foreach(int num in nums)
            {
                if (hs.Contains(num))
                {
                    return num;
                }
                hs.Add(num);
            }
            return -1;
        }
    }
}
