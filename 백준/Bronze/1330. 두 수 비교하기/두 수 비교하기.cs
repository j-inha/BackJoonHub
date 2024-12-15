using System;
namespace JIH
{
    class Program
    {
        static void Main(string[] args)
        {
         string[] n = Console.ReadLine().Split();
            
         int a = int.Parse(n[0]);
         int b = int.Parse(n[1]);

		 if (a > b)
         {
             Console.WriteLine(">");
         }
		 else if (a < b)
         {
             Console.WriteLine("<");
         }
		 else
         {
             Console.WriteLine("==");
         }

        }
    }
}