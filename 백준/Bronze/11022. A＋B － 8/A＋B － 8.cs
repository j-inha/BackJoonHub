namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
           int total = int.Parse(Console.ReadLine());
            string[] ints = new string[total];
            for (int i = 0; i < total; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int add = a + b;
                ints[i] = $"Case #{i+1}: {a} + {b} = {add}";
            }
            foreach (var number in ints)
            {
                Console.WriteLine(number);
            }
        }
    }
}