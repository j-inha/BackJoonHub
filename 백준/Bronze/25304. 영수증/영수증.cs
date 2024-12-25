namespace Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
           int total = int.Parse(Console.ReadLine());
           int count = int.Parse(Console.ReadLine());
           int c = 0;

            for (int i = 0; i < count; i++) 
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                c += a * b;
            }
            if (total == c) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}