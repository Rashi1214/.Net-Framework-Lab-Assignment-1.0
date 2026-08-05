using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operations
{
    internal class Program
    {
        static void Main()
        {
            double a, b;

            Console.Write("Enter First Number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sum = " + (a + b));
            Console.WriteLine("Difference = " + (a - b));
            Console.WriteLine("Product = " + (a * b));
            Console.WriteLine("Quotient = " + (a / b));
            Console.WriteLine("Remainder = " + (a % b));
        }
    }
}
