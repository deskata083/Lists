﻿namespace ArrayManipulator
{
    using System;
    using System.Linq;

    public class StartUp
    {
       public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "print")
            {
                var commandArgs = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0]=="addMany")
                {
                    numbers.InsertRange(int.Parse(commandArgs[1]), 
                        commandArgs.Skip(2).Select(int.Parse).ToArray());
                }
                else if (commandArgs[0] == "contains")
                {
                    int num = int.Parse(commandArgs[1]);
                    Console.WriteLine(numbers.IndexOf(num));
                }
                else if (commandArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0] == "shift")
                {
                    int num = int.Parse(commandArgs[1]);
                    num = num % numbers.Count;
                    var rem = numbers.Take(num).ToList();
                    numbers.RemoveRange(0, num);
                    numbers.AddRange(rem);
                }
                else if (commandArgs[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count-1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
