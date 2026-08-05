using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main()
        {
            int num;
            bool prime = true;

            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
                prime = false;
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }

            if (prime)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not Prime");
        }
    }
}
