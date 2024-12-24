namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split();
            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);

            m -= 45;

            if (m < 0)
            {
                m += 60;
                h -= 1;
            }

            if (h < 0) 
            { 
                h = 23; 
            }

            Console.WriteLine($"{h} {m}");
            
        }
    }
}