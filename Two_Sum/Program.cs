using System;
using System.Collections.Generic;

namespace Two_Sum
{
    internal class Program
    {
        public static int[] Two_Sum(int[] nums, int target)
        {
            Dictionary<int, int> numMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }
                numMap[nums[i]] = i;
            }
            throw new ArgumentException("No two sum solution");
        }

        static void Main()
        {
            Console.WriteLine("Enter the array of integers, separated by spaces:");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine("Enter the target integer:");
            int target = int.Parse(Console.ReadLine());

            int[] result = Two_Sum(nums, target);
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }
}