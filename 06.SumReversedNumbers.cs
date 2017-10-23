using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
   public class StartUp
    {
       public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> list = new List<int>();
            foreach (string num in numbers)
            {
                string res = "";
                for (int i = num.Length-1; i >=0; i--)
                {
                    res+=num[i];
               }
                list.Add(int.Parse(res));
            }
            //Console.WriteLine($"[{string.Join(", ", list)}]");
            Console.WriteLine(list.Sum());
        }
    }
}
