using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_Numbers_Between_1_and_N
{
    internal class Program
    {
        static void Main()
        {
            int n;

            Console.Write("Enter N: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even Numbers:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine("\nOdd Numbers:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }
    }
}
