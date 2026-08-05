using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Driven_Program
{
    internal class Program
    {
 
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Check Even/Odd");
                Console.WriteLine("2. Find Largest of Three Numbers");
                Console.WriteLine("3. Calculate Factorial");
                Console.WriteLine("4. Exit");

                Console.Write("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Number: ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        if (n % 2 == 0)
                            Console.WriteLine("Even Number");
                        else
                            Console.WriteLine("Odd Number");
                        break;

                    case 2:
                        Console.Write("Enter First Number: ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Second Number: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Third Number: ");
                        int c = Convert.ToInt32(Console.ReadLine());

                        int largest = a;

                        if (b > largest)
                            largest = b;

                        if (c > largest)
                            largest = c;

                        Console.WriteLine("Largest Number = " + largest);
                        break;

                    case 3:
                        Console.Write("Enter Number: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        long fact = 1;

                        for (int i = 1; i <= num; i++)
                            fact *= i;

                        Console.WriteLine("Factorial = " + fact);
                        break;

                    case 4:
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}
