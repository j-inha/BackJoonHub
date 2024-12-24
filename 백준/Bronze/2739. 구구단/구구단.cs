namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int i = 1;
            while (true) 
            {
                int c = N * i;
                Console.WriteLine($"{N} * {i} = {c}");
                i++;

                if (i > 9) break;
            }

        }
    }
}