using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_Using_Switch
{
    internal class Program
    {
        static void Main()
        {
            double a, b;
            int choice;

            Console.Write("Enter First Number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + (a + b));
                    break;

                case 2:
                    Console.WriteLine("Result = " + (a - b));
                    break;

                case 3:
                    Console.WriteLine("Result = " + (a * b));
                    break;

                case 4:
                    if (b != 0)
                        Console.WriteLine("Result = " + (a / b));
                    else
                        Console.WriteLine("Division by zero not possible.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
