using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string ascore = Console.ReadLine();
            int a = int.Parse(ascore);

            if (a >= 90 && a <= 100)
            {
                Console.WriteLine("A");
            }
            else if (a >= 80 && a <= 89)
            {
                Console.WriteLine("B");
            }
            else if (a >= 70 && a <= 79)
            {
                Console.WriteLine("C");
            }
            else if (a >= 60 && a <= 69)
            { Console.WriteLine("D"); }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}