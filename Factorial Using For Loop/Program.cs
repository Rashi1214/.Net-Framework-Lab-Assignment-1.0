using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Using_For_Loop
{
    internal class Program
    {
        static void Main()
        {
            int num;
            long fact = 1;

            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial = " + fact);
        }
    }
}
