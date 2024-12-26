namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
           int total = int.Parse(Console.ReadLine());
            string[] ints = new string[total];
            for (int i = 0; i < total; i++)
            {
                
                ints[i] = string.Join("", Enumerable.Repeat("*", i+1));
            }
            foreach (var number in ints)
            {
                Console.WriteLine(number);
            }
        }
    }
}