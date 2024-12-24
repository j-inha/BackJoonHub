using System.Threading.Channels;

namespace OvenTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split();
            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);
            int p = int.Parse(Console.ReadLine());

            m += p;

            if(m >= 60)
            {
                h += m / 60;
                m = m % 60;
            }
            if(h > 23)
            {
                h -= 24;
            }
            Console.WriteLine($"{h} {m}");
            
        }
    }
}