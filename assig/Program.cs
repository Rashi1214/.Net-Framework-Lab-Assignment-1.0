using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig
{
    internal class Program
    {
        static void Main()
        {
            string name;
            int rollNo;
            float marks;

            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            rollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks: ");
            marks = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n----- Student Details -----");
            Console.WriteLine("Name       : " + name);
            Console.WriteLine("Roll No.   : " + rollNo);
            Console.WriteLine("Marks      : " + marks);
        }
    }
}
