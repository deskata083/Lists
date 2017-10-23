namespace LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] length = new int[numbers.Length];
            int[] prev = new int[numbers.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }
                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }
            List<int> lis = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                lis.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            lis.Reverse();
            Console.WriteLine($"{string.Join(" ", lis)}");
        }
    }
}
