using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.ReadLine();
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("You entered: "+number);

            //Implicit Casting

            //int myInt = 9;
            // double myDouble = myInt; // Implicit casting: int to double


            //Explicit Casting

            /*double myDouble = 9.78;
            int myInt = (int)myDouble; // Explicit casting: double to int
            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            */

            //Type Conversion Methods

              int myInt = 10;
              double myDouble = 5.25;
              bool myBool = true;

              Console.WriteLine(Convert.ToString(myInt)); // Converts int to string
              Console.WriteLine(Convert.ToString(myDouble)); // Converts double to string
              Console.WriteLine(Convert.ToString(myBool)); // Converts bool to string
              Console.WriteLine(Convert.ToInt32(myDouble)); // Converts double to int
              Console.WriteLine(Convert.ToDouble(myInt)); // Converts int to double
            
             for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }

        }
    }
}
