using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions
{
    class _252_Meeting_Rooms
    {
        public _252_Meeting_Rooms()
        {
            int[][] Arr = new int[][] 
            { 
                new int[] { 15, 35 }, 
                new int[] { 0, 25 }, 
                new int[] { 7, 25 }, 
            };

            int[][] Arr1 = new int[][]
            {
                new int[]{7,10},
                new int[]{2,5}
            };
            PrintResult(canAttendMeeting(Arr)); //false
            PrintResult(canAttendMeeting(Arr1));//true

        }
        public void PrintResult(Object result)
        {
            Console.WriteLine("Starting _252_Meeting_Rooms");
            Console.WriteLine(result);
            Console.WriteLine("Ending _252_Meeting_Rooms");
        }
        /* input is one or many intervals
         * and output is true if person can attend all meetings otherwise false.
         * sort all the intervals by starting value and then use for loop to loop through all the intervals.
         * and check first interval's end number is greater than second interval's start number
         * if it's true then person can not attend all meetings.
         * otherwise person can attend the all meetings and output should be true.
         */
        public static bool canAttendMeeting(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
            for(int i = 0; i < intervals.Length - 1; i++)
            {
                if(intervals[i][1] > intervals[i + 1][0])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
