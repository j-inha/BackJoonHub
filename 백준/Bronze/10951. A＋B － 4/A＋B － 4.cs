namespace EOF
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            // 입력을 계속 읽어들이기 위한 루프
            while ((input = Console.ReadLine()) != null) // 첫 번째 입력 받기
            {
                // 입력이 비어있지 않다면 두 번째 입력 받기
                if (input.Trim() != "")
                {
                    string[] count = input.Split(); // 첫 번째 입력을 띄어쓰기로 분리
                    int a = int.Parse(count[0]); // 첫 번째 숫자
                    int b = int.Parse(count[1]); // 두 번째 숫자
                    Console.WriteLine(a + b); // 두 숫자의 합을 출력
                }
            }
        }
    }
}