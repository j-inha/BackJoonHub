using System.Linq;
using System;
using System.Text;
namespace drainage
{
    class Program
    {
        static void Main(string[] args)
        {
           int total = int.Parse(Console.ReadLine());
           StringBuilder sb = new StringBuilder();

            for (int i = 0; i < total; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                sb.AppendLine((a + b).ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}