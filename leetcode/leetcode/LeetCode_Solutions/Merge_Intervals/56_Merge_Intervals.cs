using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Merge_Intervals
{
    public class _56_Merge_Intervals
    {
        public _56_Merge_Intervals()
        {
            int[][] array = new int[3][] { new int[] { 0, 30 }, new int[] { 50, 100 }, new int[] { 15, 20 } };
            //PrintResult(Merge(array)); // TODO: Figure out how to print int[][] array
            var result = Merge(array);
            for (int n = 0; n < result.Length; n++)
            {

                // Print the row number 
                Console.WriteLine("Row({0}): ", n);

                for (int k = 0; k < result[n].Length; k++)
                {

                    // Print the elements in the row 
                    Console.WriteLine("{0} ", result[n][k]);
                }
            }

            static void PrintResult(Object result)
            {
                Console.WriteLine("Starting _56_Merge_Intervals");
                Console.WriteLine(result);
                Console.WriteLine("Ending _56_Merge_Intervals");
            }
            /* what if there is no intervals?
             * if only one interval then return one.
             * Now, we have to find out how many intervals are overlapping
             * for that first have to sort given intervals by start value
             * if first interval's end is greater than second intervals start value than 
             * create a new interval with max value of first interval end or second's end.
             * otherwise add interval into result and chsnge start and end pointer values.
             * at the end return result in to Array.
            */
            static int[][] Merge(int[][] intervals)
            {
                int n = intervals.Length;
                if (intervals == null || n == 1)
                {
                    return intervals;
                }
                Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
                List<int[]> res = new List<int[]>();
                int start = intervals[0][0];
                int end = intervals[0][1];
                for (int i = 1; i < n; i++)
                {
                    if (end >= intervals[i][0])
                    {
                        end = Math.Max(end, intervals[i][1]);
                    }
                    else
                    {
                        res.Add(new int[] { start, end });
                        start = intervals[i][0];
                        end = intervals[i][1];
                    }

                }
                res.Add(new int[] { start, end });
                return res.ToArray(); // int[][]
            }

        }
    }
}
