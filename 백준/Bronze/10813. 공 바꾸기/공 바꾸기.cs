namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력값 처리
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]); // 바구니의 개수
            int m = int.Parse(inputs[1]); // 공을 교환할 횟수

            // 바구니 초기화 (1부터 n까지 번호)
            int[] baskets = new int[n];
            for (int i = 0; i < n; i++)
            {
                baskets[i] = i + 1;
            }

            // 공 교환 처리
            for (int i = 0; i < m; i++)
            {
                //배열은 0 부터 시작함
                string[] swapInputs = Console.ReadLine().Split();
                int a = int.Parse(swapInputs[0]) - 1;
                int b = int.Parse(swapInputs[1]) - 1;

                // 두 바구니의 공 교환
                int c = baskets[a];
                baskets[a] = baskets[b];
                baskets[b] = c;
            }

            // 결과 출력
            Console.WriteLine(string.Join(" ", baskets));
        }
    }
}