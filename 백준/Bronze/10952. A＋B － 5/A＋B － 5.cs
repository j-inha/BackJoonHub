namespace addition5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            while(true)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                i++;
                if(a == 0 && b == 0)
                {
                    break;
                }
                Console.WriteLine($"{a + b}");
            }
            
        }
    }
}