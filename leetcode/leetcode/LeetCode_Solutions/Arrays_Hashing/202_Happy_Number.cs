using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _202_Happy_Number
    {
        public _202_Happy_Number()
        {
            int n = 13;
            int n1 = 25;
            int n2 = 77;
            int n3 = 7;
            Console.WriteLine("Happy Number= {0} ", isHappyNum(n));
            Console.WriteLine("Happy Number= {0} ", isHappyNum(n1));
            Console.WriteLine("Happy Number= {0} ", isHappyNum(n2));
            Console.WriteLine("Happy Number= {0} ", isHappyNum(n3));
        }
        public bool isHappyNum(int n)
        {
            if( n == 1 || n == 7)
            {
                return true;
            }
            if(n < 10)
            {
                return false;
            }
            var sum = 0;
            while( n > 0)
            {
                var r = n % 10;
                n = n/10;
                sum += r * r;
            }
            return sum == 1 || isHappyNum(sum);
        }
    }
}
