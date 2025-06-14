using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverage
{
    internal class Program
    {
        private static object array;

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int num = 0;
            double avg = 0.0;
            Console.WriteLine("Enter 10 Numbers:- ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                num += numbers[i];

            }
            avg = num / 10.0;

            Console.WriteLine("Sum of 10 numbers : " + num);
            Console.WriteLine("Average of 10 numbers : " + avg);
        }
    }
}
