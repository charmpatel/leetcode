using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using leetcode.LeetCode_Solutions.Arrays;

namespace leetcode_tests.Leetcode_Solutions_Test.HashTable
{
    class _1_Two_Sum_Unit_Test
    {
        int target;
        int[] nums = null;
        _1_Two_Sum two_Sum = null;

        [SetUp]
        public void Setup()
        {
           two_Sum = new _1_Two_Sum();
        }

        [Test]
        public void TargetValueAtEndTest()
        {
            target = 19;
            nums = new int[] { 11, 12, 14, 15, 16, 18, 100, 2, 7 };

            var result = two_Sum.twoSum(nums, target);
            Console.WriteLine("Testing test 1");
            Assert.AreEqual(new int[2] { 1, 8 }, result);
        }

        [Test]
        public void InputWithOnlyTwoValuesTest()
        {
            target = 9;
            nums = new int[] { 3, 6 };
            var result = two_Sum.twoSum(nums, target);
            Assert.AreEqual(new int[2] { 0, 1}, result);
        }
    }

}
