namespace ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<string> command;

            do
            {
                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    for (int i = numbers.Count - 1; i >= 0; i--)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    if (position < numbers.Count)
                    {
                        numbers.Insert(position, element);
                    }
                    else
                    {
                        numbers.Add(element);
                    }
                }
            } while ((command[0] != "Odd") && (command[0] != "Even"));

            if (command[0] == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if ((numbers[i] % 2 == 0))
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            }
            else if (command[0] == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if ((numbers[i] % 2 != 0))
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
