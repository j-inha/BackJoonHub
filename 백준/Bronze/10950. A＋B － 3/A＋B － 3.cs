using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] list = { };
            List<int> lists = list.ToList();

            for (int i = 1; i <= N ; i++)
            {
                string[] test = Console.ReadLine().Split();
                int a = int.Parse(test[0]);
                int b = int.Parse(test[1]);

                lists.Add(a + b);
            }
            foreach (var number in lists)
            {
                Console.WriteLine(number);
            }
        }
    }
}