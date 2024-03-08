using System;
using System.Collections.Generic;

namespace TwoSumSolution
{
    class Program
    {
        public static int[] FindTwoSumIndices(int[] numbers, int targetSum)
        {
            List<(int number, int index)> numberIndices = new List<(int number, int index)>();

            for (int i = 0; i < numbers.Length; i++)
            {
                numberIndices.Add((numbers[i], i));
            }

            for (int i = 0; i < numberIndices.Count; i++)
            {
                int complement = targetSum - numberIndices[i].number;

                for (int j = i + 1; j < numberIndices.Count; j++)
                {
                    if (numberIndices[j].number == complement)
                    {
                        return new int[] { numberIndices[i].index, numberIndices[j].index };
                    }
                }
            }

            return new int[0];
        }

        static void Main(string[] args)
        {
            Console.Write("Enter numbers and separated the by space: ");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Enter the target sum: ");
            int targetSum = int.Parse(Console.ReadLine());

            int[] resultIndices = FindTwoSumIndices(numbers, targetSum);
            if (resultIndices.Length > 0)
            {
                Console.WriteLine("Output: [{0}]", string.Join(", ", resultIndices));
            }
            else
            {
                Console.WriteLine("Solution can't be found");
            }
        }
    }
}
