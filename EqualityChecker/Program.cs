using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Two numbers are same");
            }
            else
            {
                Console.WriteLine("Two numbers are different");
            }

        }
    }
}
