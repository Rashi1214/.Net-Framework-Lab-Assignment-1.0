using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    internal class Program
    {
        static void Main()
        {
            int num, rem, rev = 0, temp;

            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }

            if (temp == rev)
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a Palindrome Number");
        }
    }
}
