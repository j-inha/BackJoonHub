namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dice = Console.ReadLine().Split();
            int d1 = int.Parse(dice[0]);
            int d2 = int.Parse(dice[1]);
            int d3 = int.Parse(dice[2]);
            int prize = 0;

            if (d1 == d2 && d3 == d1) // 전부 다 같을때
            {
                prize = 10000 + d1 * 1000;
            }
            else if (d1 != d2 && d3 != d1 && d2 != d3) // 전부 다 다를때
            {
                prize = Math.Max(Math.Max(d1,d2), d3) * 100;
            }
            else if ( d1 == d2 && d2 != d3 ) //두 수만 다를 때 (1번과 2번 주사위 같을 떄)
            {
                prize = 1000 + d1 * 100;
            }
            else if (d2 == d3 && d1 != d3) //두 수만 다를 때 (2번과 3번 주사위 같을 떄)
            {
                prize = 1000 + d2 * 100;
            }
            else if (d1 == d3 && d2 != d3) //두 수만 다를 때 (1번과 3번 주사위 같을 떄)
            {
                prize = 1000 + d1 * 100;
            }
            Console.WriteLine(prize);
            
        }
    }
}