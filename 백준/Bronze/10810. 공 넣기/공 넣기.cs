namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(); // 처음 입력정보
            int a = int.Parse(number[0]); // 바구니크기
            int b = int.Parse(number[1]); //공을 넣을 횟수

            //처음입력정보에서 첫번째 값이 바구니 개수 이므로 바구니 배열선언 
            int[] basket = new int[a];
            
            for (int i = 0; i < b; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                int c = int.Parse(numbers[0]); //시작점
                int d = int.Parse(numbers[1]); //끝점
                int e = int.Parse(numbers[2]); //넣을값

                for (int j = c ; j <= d; j++)
                {
                    basket[j-1] = e;
                    //배열은 0부터 시작함
                }
               
            }
            for(int i = 0; i < a; i++)
            {
                Console.Write(basket[i] + " ");
            }

        }
    }
}