using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Enter your integers");
              int[] numbers = new int[10];
              for (int i  = 0; i < numbers.Length; i++)
              {
                  numbers[i] = int.Parse(Console.ReadLine());

              }
            int[] uniqnumbers = numbers.Distinct().ToArray();

            Console.WriteLine("Unique integers:");
            foreach (int num in uniqnumbers)
            {
                Console.WriteLine(num);
            }
            }
        }
    }




