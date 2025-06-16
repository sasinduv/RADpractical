using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibalBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //create a list of numbers 1 to 100.
            List<int> numbers = Enumerable.Range(1, 100).ToList();
            var divisibleBy3 = numbers.Where(n => n % 3 == 0).ToList();
            Console.WriteLine("Numbers divisible by 3: " + divisibleBy3);

            foreach (var number in divisibleBy3)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
            */
            Array Numbers = new int[100];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers.SetValue(i + 1, i);
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                if ((int)Numbers.GetValue(i) % 3 == 0)
                {
                    Console.WriteLine(Numbers.GetValue(i));
                }
            }
            Console.ReadLine();

        }
    }
}
