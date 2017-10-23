namespace SearchForANumber
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            while (numbers.Contains(command[0]))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == command[0])
                    {
                        int c = (int)command[1];
                        int index = i - c;
                        int len = 2 * c + 1;

                        if (index < 0)
                        {
                            len = len + index; index = 0;
                        }

                        if (index + len > numbers.Count)
                        {
                            len = numbers.Count - index;
                        }
                        numbers.RemoveRange(index, len);
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
