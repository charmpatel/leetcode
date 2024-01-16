using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions
{
    class _435_Non_Overlapping_Intervals
    {
        public _435_Non_Overlapping_Intervals()
        {
            int[][] arr =
            {
                new int[]{1,2},
                new int[]{2,3},
                new int[]{3,4},
                new int[]{1,3}
            };
            Console.WriteLine(removeOverlapIntervals(arr));
        }

        public static int removeOverlapIntervals (int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => { return a[1] - b[1]; });
            int res = 0;
            int start = intervals[0][1];
            for(int i = 1; i < intervals.Length; i++)
            {
                if(intervals[i][0] < start)
                {
                    res++;
                }
                else
                {
                    start = intervals[i][1];
                }
            }
            return res;
        }
    }
}
