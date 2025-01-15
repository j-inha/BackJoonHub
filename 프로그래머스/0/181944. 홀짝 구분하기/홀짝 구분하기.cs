using System;

public class Example
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if(a % 2 == 0)
        {
            Console.WriteLine($"{a} is even");
        }
        else
        { Console.WriteLine($"{a} is odd"); }
    }
}