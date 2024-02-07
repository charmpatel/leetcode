/* 359 - Logger Rate Limiter
   Topic - 
Design a logger system that receives a stream of messages along with their timestamps. Each unique message should only be printed at most every 10 seconds (i.e. a message printed at timestamp t will prevent other identical messages from being printed until timestamp t + 10).
All messages will come in chronological order. Several messages may arrive at the same timestamp.
Implement the Logger class:
Logger() Initializes the logger object.
bool shouldPrintMessage(int timestamp, string message) Returns true if the message should be printed in the given timestamp, otherwise returns false.
Example 1:
Input
["Logger", "shouldPrintMessage", "shouldPrintMessage", "shouldPrintMessage", "shouldPrintMessage", "shouldPrintMessage", "shouldPrintMessage"]
[[], [1, "foo"], [2, "bar"], [3, "foo"], [8, "bar"], [10, "foo"], [11, "foo"]]
Output
[null, true, true, false, false, false, true]
Explanation
Logger logger = new Logger();
logger.shouldPrintMessage(1, "foo");  // return true, next allowed timestamp for "foo" is 1 + 10 = 11
logger.shouldPrintMessage(2, "bar");  // return true, next allowed timestamp for "bar" is 2 + 10 = 12
logger.shouldPrintMessage(3, "foo");  // 3 < 11, return false
logger.shouldPrintMessage(8, "bar");  // 8 < 12, return false
logger.shouldPrintMessage(10, "foo"); // 10 < 11, return false
logger.shouldPrintMessage(11, "foo"); // 11 >= 11, return true, next allowed timestamp for "foo" is 11 + 10 = 21
*/

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
