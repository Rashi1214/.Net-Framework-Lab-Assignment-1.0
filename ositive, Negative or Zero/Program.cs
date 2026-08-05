using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ositive__Negative_or_Zero
{
    internal class Program
    {
        static void Main()
        {
            int num;

            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("Positive Number");
            else if (num < 0)
                Console.WriteLine("Negative Number");
            else
                Console.WriteLine("Zero");
        }
    }
}
