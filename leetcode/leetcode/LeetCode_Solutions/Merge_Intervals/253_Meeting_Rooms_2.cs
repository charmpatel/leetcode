using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Merge_Intervals
{
    public class _253_Meeting_Rooms_2
    {
        public _253_Meeting_Rooms_2()
        {
            int[][] array = new int[3][] { new int[] { 0, 30 }, new int[] { 5, 10 }, new int[] { 15, 20 } };
            PrintResult(MinMeetingRooms(array)); 
        }

        public void PrintResult(Object result)
        {
            Console.WriteLine("Starting _253_Meeting_Rooms_2");
            Console.WriteLine(result);
            Console.WriteLine("Ending _253_Meeting_Rooms_2");
        }
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return 0;
            }
            int[] start = new int[intervals.Length];
            int[] end = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }

            Array.Sort(end);
            Array.Sort(start);
            int startpointer = 0;
            int endpointer = 0;
            int usedRooms = 0;

            while (startpointer < intervals.Length)
            {
                if (start[startpointer] >= end[endpointer])
                {
                    usedRooms -= 1;
                    endpointer += 1;
                }
                usedRooms += 1;
                startpointer += 1;
            }
            return usedRooms;
        }

    }
}
