namespace SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> list = numbers.Take<int>(command[0]).ToList();
            list.RemoveRange(0, command[1]);
            bool fl = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == command[2])
                {
                    fl = true;
                }
            }
            if (fl)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
