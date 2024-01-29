using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _359_Logger_Rate_Limiter
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        public _359_Logger_Rate_Limiter()
        {
            /*int timestamp = new int { 1, 3, 5, 8, 10 };
            string message1 = new string { "foo", "bar", "here", "foo", "bar" };
            Console.WriteLine(logTime(timestamp, message1));*/

            Console.WriteLine(logTime(1, "foo"));
            Console.WriteLine(logTime(2, "bar"));
            Console.WriteLine(logTime(3, "foo"));
            Console.WriteLine(logTime(8, "bar"));
            Console.WriteLine(logTime(10, "foo"));
            Console.WriteLine(logTime(11, "foo"));
            Console.WriteLine(logTime(17, "foo"));
            Console.WriteLine(logTime(21, "foo"));
        }
        
        public bool logTime(int timestamp, string message)
        {
            if (!dict.ContainsKey(message))
            {
                dict.Add(message, timestamp);
                return true;
            }
            if( timestamp - dict[message] >= 10)
            {
                dict[message] = timestamp;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
