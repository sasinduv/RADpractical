using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 1, k = 1; // Initialize 'value' to 1 to avoid CS0165 error  
            Console.WriteLine("Enter a number to calculate its factorial:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                value = i * value;
            }
            Console.WriteLine($"The factorial of {num}! is: {value}");
        }
    }
}
