using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _359_Logger_Rate_Limiter
    {
        public _359_Logger_Rate_Limiter()
        {
            /*int timestamp = new int { 1, 3, 5, 8, 10 };
            string message1 = new string { "foo", "bar", "here", "foo", "bar" };
            Console.WriteLine(logTime(timestamp, message1));*/
        }
        
        public bool logTime(int timestamp, string message)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
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
