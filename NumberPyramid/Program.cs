using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Pyramid");
            int n = int.Parse(Console.ReadLine());

            int i, j, k;
            for (i = 0; i < n; i++)
            {
                // Print leading spaces
                for (j = n - i; j > 1; j--)
                {
                    Console.Write(" ");
                }
                // Print increasing numbers
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
